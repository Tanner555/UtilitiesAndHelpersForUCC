using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController.Items;
using Opsive.UltimateCharacterController.Utility.Builders;
using Opsive.UltimateCharacterController.Items.Actions;
using Opsive.UltimateCharacterController.Character;
using Opsive.UltimateCharacterController.Inventory;
using Opsive.UltimateCharacterController.Character.Abilities.AI;
using Opsive.UltimateCharacterController.Objects.CharacterAssist;
//using Opsive.UltimateCharacterController.Editor.Managers;
using Abilities = Opsive.UltimateCharacterController.Character.Abilities;
using UnityEngine.AI;

namespace UtilitiesAndHelpersForUCC
{
    public class CharacterBuildAndSpawnUtility : MonoBehaviour
    {
        #region Enums
        public enum EThirdPersonMovementTypes
        {
            Adventure = 0,
            Combat = 1,
            FourLegged = 2,
            Pseudo3D = 3,
            RPG = 4,
            TopDown = 5
        }
        #endregion

        #region Fields
        [Header("Spawner Fields")]
        [Tooltip("Used to Spawn a Character")]
        public GameObject CharacterPrefabToSpawn;
        public string CharacterName;
        public float TimeBeforeSpawnerIsDestroyed = 0.5f;
        [Tooltip("Determines Whether The Character Will Be Built Dynamically Through the UCC Character Builder.")]
        public bool bBuildCharacterCompletely = false;
        [Tooltip("This will most likely fail and produce several errors.")]
        public bool bAttemptToBuildItems = false;
        [Header("Gizmos Fields")]
        [Tooltip("Used to Determine Gizmos Color")]
        public bool isFriendlyCharacter = false;
        public Color FriendlyColor = Color.green;
        public Color EnemyColor = Color.red;
        public float GizmosRadius = 1.5f;
        //Used For Adding Components and setting up character
        [HideInInspector]
        public GameObject spawnedGameObject = null;

        #endregion

        #region CharacterBuilderFields
        [Header("CharacterBuilder Fields")]
        [Tooltip("The animator controller that the character should use")]
        [SerializeField] public RuntimeAnimatorController m_AnimatorController;
        [Tooltip("Can the character hold items?")]
        [SerializeField] public bool m_AddItems = true;
        [Tooltip("A reference to the ItemCollection used by the ItemSetManager and Inventory.")]
        [SerializeField] public ItemCollection m_ItemCollection;
        [Tooltip("Does the character have health?")]
        [SerializeField] public bool m_AddHealth = true;
        [Tooltip("Should Unity's IK system be added?")]
        [SerializeField] public bool m_AddUnityIK = true;
        [Tooltip("Should footstep effects play when moving?")]
        [SerializeField] public bool m_AddFootEffects = true;
        [Tooltip("Should the standard set of abilities be added to the character?")]
        [SerializeField] public bool m_AddStandardAbilities = true;
        [Tooltip("Is the character an AI agent?")]
        [SerializeField] public bool m_AIAgent;
        [Tooltip("Should the NavMeshAgent be added to the AI agent?")]
        [SerializeField] public bool m_AddNavMeshAgent;
        [Tooltip("Should the camera be assigned to the character after the character has been created?")]
        [SerializeField] public bool m_AssignCamera = true;
        [Tooltip("Movement Type That'll Be Used By The Character Locomotion and Camera Controller")]
        [SerializeField] public EThirdPersonMovementTypes m_ThirdPersonMovementType;

        [HideInInspector]
        public UltimateCharacterLocomotion characterLocomotion;
        #endregion

        #region ItemBuilderFields
        [Header("Item Builder Fields")]
        [Header("Weapon Positions and Rotations")]
        public WeaponLocalPositionsObject WeaponPositionsObject;

        public List<LocalWeaponPositionsClass> WeaponPositionsList
        {
            get { return WeaponPositionsObject != null ? WeaponPositionsObject.WeaponPositionsAndRotations : new List<LocalWeaponPositionsClass>(); }
        }

        [Header("Used For AddableItem Settings")]
        public AddableItemsForSpawnerObject SerializedAddableItem;

        public List<AddableItemForSpawner> AddableItemsList
        {
            get { return SerializedAddableItem.AddableItems; }
        }
        #endregion

        #region BuildThroughEditorFields
        [Header("Build Character Through Editor Fields")]
        public GameObject CharacterToBuildThroughEditor;
        
        #endregion

        #region Properties
        public Color gizmosColor
        {
            get
            {
                return isFriendlyCharacter ? FriendlyColor : EnemyColor;
            }
        }
        #endregion

        #region UnityMessages
        protected virtual void OnEnable()
        {
            StartCoroutine(GetReadyToInitializeCharacter());
        }

        protected virtual void OnDisable()
        {
            StopAllCoroutines();
        }

        protected virtual void OnDrawGizmos()
        {
            Gizmos.color = gizmosColor;
            Gizmos.DrawWireSphere(transform.position, GizmosRadius);
        }
        #endregion

        #region Initialization
        public virtual IEnumerator GetReadyToInitializeCharacter()
        {
            yield return new WaitForSeconds(0);
            if (CharacterPrefabToSpawn != null)
            {
                //Spawn The Given Character Prefab
                spawnedGameObject = SpawnCharacterPrefab(GetCharacterToSpawn(), GetCharacterName());
                //From CharacterBuilder-BuildCharacter
                yield return StartCoroutine(CharacterBuilder_BuildCharacter());
                //From CharacterSetup-SetupCharacter
                yield return StartCoroutine(CharacterSetup_SetupCharacter());
                //From ItemBuilder-BuildItem
                yield return StartCoroutine(ItemBuilder_BuildItem());
                //From CharacterBuilder-UpdateCharacter
                yield return StartCoroutine(CharacterBuilder_UpdateCharacter());
                //From CharacterSetup-UpdateCharacterSetup
                yield return StartCoroutine(CharacterSetup_UpdateCharacterSetup());
            }
            //Wait For All Initialization To Complete
            //Before Destroying This gameObject.
            Destroy(gameObject, TimeBeforeSpawnerIsDestroyed);
        }
        #endregion

        #region Getters
        public virtual string GetThirdPersonMovementType(EThirdPersonMovementTypes movementType)
        {
            switch (movementType)
            {
                case EThirdPersonMovementTypes.Adventure:
                    return "Opsive.UltimateCharacterController.ThirdPersonController.Character.MovementTypes.Adventure";
                case EThirdPersonMovementTypes.Combat:
                    return "Opsive.UltimateCharacterController.ThirdPersonController.Character.MovementTypes.Combat";
                case EThirdPersonMovementTypes.FourLegged:
                    return "Opsive.UltimateCharacterController.ThirdPersonController.Character.MovementTypes.FourLegged";
                case EThirdPersonMovementTypes.Pseudo3D:
                    return "Opsive.UltimateCharacterController.ThirdPersonController.Character.MovementTypes.Pseudo3D";
                case EThirdPersonMovementTypes.RPG:
                    return "Opsive.UltimateCharacterController.ThirdPersonController.Character.MovementTypes.RPG";
                case EThirdPersonMovementTypes.TopDown:
                    return "Opsive.UltimateCharacterController.ThirdPersonController.Character.MovementTypes.TopDown";
                default:
                    return "";
            }
        }

        /// <summary>
        /// Override This Method If You Need To Obtain A Character's Prefab Through Script
        /// </summary>
        /// <returns></returns>
        public virtual GameObject GetCharacterToSpawn()
        {
            return CharacterPrefabToSpawn;
        }

        /// <summary>
        /// Override This Method If You Need To Obtain A Character's Name Through Script
        /// </summary>
        /// <returns></returns>
        public virtual string GetCharacterName()
        {
            return CharacterName;
        }
        #endregion

        #region MethodsToOverride
        public virtual IEnumerator CharacterBuilder_BuildCharacter()
        {
            yield return new WaitForSeconds(0);
            if (bBuildCharacterCompletely)
            {
                // Use the Character Builder to add the Ultimate Character Controller components.
                CharacterBuilder.BuildCharacter(spawnedGameObject, /*AddAnimator*/true, m_AnimatorController, /*FPMovementType*/string.Empty,
                                                GetThirdPersonMovementType(m_ThirdPersonMovementType), /*startFPPerspective*/false,
                                                /*FPHiddenItems*/null, /*ShadowCastMat*/null, /*AiAgent*/m_AIAgent);
                CharacterBuilder.BuildCharacterComponents(spawnedGameObject, /*AiAgent*/true, m_AddItems, m_ItemCollection, /*FirstPersonItems*/false,
                    /*AddHealth*/m_AddHealth, /*AddIK*/m_AddUnityIK, /*AddFootsteps*/m_AddFootEffects, /*AddStandardAbilities*/m_AddStandardAbilities, /*AddNavMeshAgent*/m_AddNavMeshAgent);
                // Ensure the smoothed bones have been added to the character.
                characterLocomotion = spawnedGameObject.GetComponent<UltimateCharacterLocomotion>();
                characterLocomotion.AddDefaultSmoothedBones();

                // The Animator Monitor is one of the first components added and the item system hasn't been added to the character yet. Initialize the Item Parameters after the item system has been setup.
                if (m_AddItems)
                {
                    var animatorMonitor = spawnedGameObject.GetComponent<AnimatorMonitor>();
                    if (animatorMonitor != null)
                    {
                        animatorMonitor.InitializeItemParameters();
                    }
                }

                // The camera can automatically be assigned ot the new character.
                if (m_AssignCamera && !m_AIAgent)
                {
                    var camera = Opsive.UltimateCharacterController.Utility.UnityEngineUtility.FindCamera(spawnedGameObject);
                    if (camera != null)
                    {
                        var cameraController = camera.GetComponent<Opsive.UltimateCharacterController.Camera.CameraController>();
                        if (cameraController != null)
                        {
                            cameraController.Character = spawnedGameObject;
                        }
                    }
                }
            }
        }

        public virtual IEnumerator CharacterSetup_SetupCharacter()
        {
            yield return new WaitForSeconds(0);
        }

        public virtual IEnumerator ItemBuilder_BuildItem()
        {
            yield return new WaitForSeconds(0f);

            if (bBuildCharacterCompletely && bAttemptToBuildItems)
            {
                if (SerializedAddableItem == null) Debug.LogError("No SerializedAddableItem on character");

                InventoryBase inventoryBase;
                Animator _animatorOnCharacter;
                if (SerializedAddableItem != null && AddableItemsList != null && AddableItemsList.Count > 0 &&
                    (inventoryBase = spawnedGameObject.GetComponent<InventoryBase>()) != null &&
                    (_animatorOnCharacter = spawnedGameObject.GetComponent<Animator>()) != null)
                {
                    foreach (var _addableItem in AddableItemsList)
                    {
                        //Build Items
                        Transform _handAssignmentTransform = _addableItem.HandAssignment == EItemBuilderHandAssignmentForSpawner.Left ?
                            _animatorOnCharacter.GetBoneTransform(HumanBodyBones.LeftHand) :
                            _animatorOnCharacter.GetBoneTransform(HumanBodyBones.RightHand);
                        ItemSlot _handAssignmentItemSlot = _handAssignmentTransform.GetComponentInChildren<ItemSlot>();
                        int _handAssignmentSlotID = _handAssignmentItemSlot.ID;
                        GameObject _builtItem = ItemBuilder.BuildItem(_addableItem.ItemName, _addableItem.ItemType, _addableItem.AnimatorItemID, spawnedGameObject,
                            _handAssignmentSlotID, /*AddToDefaultLoadout*/true, /*AddFPPerspective*/false, /*FPObject*/null,/*FPObjectAnim*/null,
                            /*FPVisibleItem*/null, /*FPItemSlot*/null, /*FPVisibleItemAnim*/null,/*AddTPPerspective*/true,
                            /*TPObject*/_addableItem.Base, /*TPItemSlot*/_handAssignmentItemSlot,
                            _addableItem.ThirdPersonItemAnimator != null ? _addableItem.ThirdPersonItemAnimator : null, /*ShadowCastMat*/null,
                            _addableItem.Type == EItemBuilderItemTypeForSpawner.Melee ? ItemBuilder.ActionType.MeleeWeapon : ItemBuilder.ActionType.ShootableWeapon, _addableItem.ItemType);

                        //Assign The Animator Avatar If It Exists
                        Transform _childBuildItemReference = _handAssignmentItemSlot.transform.Find(_builtItem.name);
                        Animator _TPCObjectAnimator;
                        if (_childBuildItemReference != null &&
                            _addableItem.ThirdPersonItemAnimator != null && _addableItem.ThirdPersonItemAnimAvatar &&
                            (_TPCObjectAnimator = _childBuildItemReference.GetComponent<Animator>()) != null)
                        {
                            _TPCObjectAnimator.avatar = _addableItem.ThirdPersonItemAnimAvatar;
                        }

                        //PickUp Items
                        if (_addableItem.MyItemPickup != null)
                        {
                            _addableItem.MyItemPickup.DoItemPickup(spawnedGameObject, inventoryBase, _handAssignmentSlotID, true, true);
                        }

                        Vector3 _position = Vector3.zero;
                        Vector3 _rotation = Vector3.zero;
                        //Set Specific Position and Rotation Only If ItemType Has
                        //Been Assigned in the Inspector
                        if (AddableItemHasSpecificPosition(_addableItem.ItemType, out _position, out _rotation))
                        {
                            _builtItem.transform.localPosition = _position;
                            _builtItem.transform.localEulerAngles = _rotation;
                        }
                        //else
                        //{
                        //    _builtItem.transform.localPosition = _addableItem.LocalPosition;
                        //    _builtItem.transform.localEulerAngles = _addableItem.LocalRotation;
                        //}
                    }
                }
            }
        }

        public virtual IEnumerator CharacterBuilder_UpdateCharacter()
        {
            yield return new WaitForSeconds(0);
        }

        public virtual IEnumerator CharacterSetup_UpdateCharacterSetup()
        {
            yield return new WaitForSeconds(0);
        }
        #endregion

        #region CharacterSpawnHelpers
        public virtual GameObject SpawnCharacterPrefab(GameObject _character, string _name)
        {
            GameObject _spawnedC = Instantiate(_character, transform.position, transform.rotation) as GameObject;
            _spawnedC.name = _name;
            return _spawnedC;
        }
        #endregion

        #region ItemBuilderHelpers
        public bool AddableItemHasSpecificPosition(ItemType _itemType, out Vector3 _position, out Vector3 _rotation)
        {
            _position = Vector3.zero;
            _rotation = Vector3.zero;

            if (WeaponPositionsObject == null) return false;

            foreach (var _wPos in WeaponPositionsList)
            {
                if (_wPos.m_ItemType == _itemType)
                {
                    _position = _wPos.m_LocalPosition;
                    _rotation = _wPos.m_LocalRotation;
                    return true;
                }
            }

            return false;
        }

        public Transform CreateChildObject(Transform parent, string name, Vector3 offset, Vector3 _eulerRotation)
        {
            var child = new GameObject(name).transform;
            child.parent = parent;
            child.localPosition = offset;
            child.transform.localEulerAngles = _eulerRotation;
            return child;
        }
        #endregion

        #region CharacterBuilderThroughEditor
        public void BuildCharacterThroughEditor()
        {
            if (Application.isPlaying || CharacterToBuildThroughEditor == null) return;

            if (bBuildCharacterCompletely)
            {
                // Use the Character Builder to add the Ultimate Character Controller components.
                CharacterBuilder.BuildCharacter(CharacterToBuildThroughEditor, /*AddAnimator*/true, m_AnimatorController, /*FPMovementType*/string.Empty,
                                                GetThirdPersonMovementType(m_ThirdPersonMovementType), /*startFPPerspective*/false,
                                                /*FPHiddenItems*/null, /*ShadowCastMat*/null, /*AiAgent*/m_AIAgent);
                CharacterBuilder.BuildCharacterComponents(CharacterToBuildThroughEditor, /*AiAgent*/true, m_AddItems, m_ItemCollection, /*FirstPersonItems*/false,
                    /*AddHealth*/m_AddHealth, /*AddIK*/m_AddUnityIK, /*AddFootsteps*/m_AddFootEffects, /*AddStandardAbilities*/m_AddStandardAbilities, /*AddNavMeshAgent*/m_AddNavMeshAgent);
                // Ensure the smoothed bones have been added to the character.
                var _characterLocomotion = CharacterToBuildThroughEditor.GetComponent<UltimateCharacterLocomotion>();
                _characterLocomotion.AddDefaultSmoothedBones();

                // The Animator Monitor is one of the first components added and the item system hasn't been added to the character yet. Initialize the Item Parameters after the item system has been setup.
                if (m_AddItems)
                {
                    //var animatorMonitor = CharacterToBuildThroughEditor.GetComponent<AnimatorMonitor>();
                    //if (animatorMonitor != null)
                    //{
                    //    animatorMonitor.InitializeItemParameters();
                    //}
                }
            }
        }

        public void BuildCharacterItemsThroughEditor()
        {
            if (Application.isPlaying || CharacterToBuildThroughEditor == null) return;

            if (bBuildCharacterCompletely && bAttemptToBuildItems)
            {
                if (SerializedAddableItem == null) Debug.LogError("No SerializedAddableItem on character");

                InventoryBase inventoryBase;
                Animator _animatorOnCharacter;
                if (SerializedAddableItem != null && AddableItemsList != null && AddableItemsList.Count > 0 &&
                    (inventoryBase = CharacterToBuildThroughEditor.GetComponent<InventoryBase>()) != null &&
                    (_animatorOnCharacter = CharacterToBuildThroughEditor.GetComponent<Animator>()) != null)
                {
                    foreach (var _addableItem in AddableItemsList)
                    {
                        //Build Items
                        Transform _handAssignmentTransform = _addableItem.HandAssignment == EItemBuilderHandAssignmentForSpawner.Left ?
                            _animatorOnCharacter.GetBoneTransform(HumanBodyBones.LeftHand) :
                            _animatorOnCharacter.GetBoneTransform(HumanBodyBones.RightHand);
                        ItemSlot _handAssignmentItemSlot = _handAssignmentTransform.GetComponentInChildren<ItemSlot>();
                        int _handAssignmentSlotID = _handAssignmentItemSlot.ID;
                        GameObject _builtItem = ItemBuilder.BuildItem(_addableItem.ItemName, _addableItem.ItemType, _addableItem.AnimatorItemID, CharacterToBuildThroughEditor,
                            _handAssignmentSlotID, /*AddToDefaultLoadout*/true, /*AddFPPerspective*/false, /*FPObject*/null,/*FPObjectAnim*/null,
                            /*FPVisibleItem*/null, /*FPItemSlot*/null, /*FPVisibleItemAnim*/null,/*AddTPPerspective*/true,
                            /*TPObject*/_addableItem.Base, /*TPItemSlot*/_handAssignmentItemSlot,
                            _addableItem.ThirdPersonItemAnimator != null ? _addableItem.ThirdPersonItemAnimator : null, /*ShadowCastMat*/null,
                            _addableItem.Type == EItemBuilderItemTypeForSpawner.Melee ? ItemBuilder.ActionType.MeleeWeapon : ItemBuilder.ActionType.ShootableWeapon, _addableItem.ItemType);

                        //Assign The Animator Avatar If It Exists
                        Transform _childBuildItemReference = _handAssignmentItemSlot.transform.Find(_builtItem.name);
                        Animator _TPCObjectAnimator;
                        if (_childBuildItemReference != null &&
                            _addableItem.ThirdPersonItemAnimator != null && _addableItem.ThirdPersonItemAnimAvatar &&
                            (_TPCObjectAnimator = _childBuildItemReference.GetComponent<Animator>()) != null)
                        {
                            _TPCObjectAnimator.avatar = _addableItem.ThirdPersonItemAnimAvatar;
                        }

                        //PickUp Items
                        //if (_addableItem.MyItemPickup != null)
                        //{
                        //    _addableItem.MyItemPickup.DoItemPickup(CharacterToBuildThroughEditor, inventoryBase, _handAssignmentSlotID, true, true);
                        //}

                        //Vector3 _position = Vector3.zero;
                        //Vector3 _rotation = Vector3.zero;
                        ////Set Specific Position and Rotation Only If ItemType Has
                        ////Been Assigned in the Inspector
                        //if (AddableItemHasSpecificPosition(_addableItem.ItemType, out _position, out _rotation))
                        //{
                        //    _builtItem.transform.localPosition = _position;
                        //    _builtItem.transform.localEulerAngles = _rotation;
                        //}
                        ////else
                        ////{
                        ////    _builtItem.transform.localPosition = _addableItem.LocalPosition;
                        ////    _builtItem.transform.localEulerAngles = _addableItem.LocalRotation;
                        ////}
                    }
                }
            }
        }
        #endregion
    }
}