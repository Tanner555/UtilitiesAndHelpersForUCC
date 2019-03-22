using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController;
using Opsive.UltimateCharacterController.Character;
using Opsive.UltimateCharacterController.Input;
using Opsive.UltimateCharacterController.Camera;
using Opsive.UltimateCharacterController.Inventory;
using Opsive.UltimateCharacterController.Utility.Builders;
using Opsive.UltimateCharacterController.Objects.CharacterAssist;

namespace UtilitiesAndHelpersForUCC
{
    #region Enums
    public enum EItemBuilderItemTypeForSpawner
    {
        Melee = 0, Shootable = 1
    }

    public enum EItemBuilderHandAssignmentForSpawner
    {
        Left = 0, Right = 1
    }
    #endregion

    #region AddableItemClass
    /// <summary>
    /// Specifies an item which can be added to the generated character.
    /// </summary>
    [System.Serializable]
    public class AddableItemForSpawner
    {
        #region BaseFields
        [Tooltip("Not Needed For Data, For Easy Editor Access Only")]
        [SerializeField] public string AddableItemName;
        //Base Fields
        [Header("Base Addable Item Fields")]
        [Tooltip("The Third Person Controller ItemType reference")]
        [SerializeField] protected ItemType m_ItemType;
        [Tooltip("A reference to the base object to use")]
        [SerializeField] protected GameObject m_Base;
        [Tooltip("A reference to the Item To Pickup")]
        [SerializeField] protected ItemPickup m_ItemPickup;
        [Tooltip("The ID of the Item within the Animator")]
        [SerializeField] protected int m_AnimatorItemID;
        [Tooltip("Animator Used To Build Third Person Item")]
        [SerializeField] protected RuntimeAnimatorController m_ThirdPersonItemAnimator;
        [Tooltip("Avatar For Animator Used To Build Third Person Item")]
        [SerializeField] protected Avatar m_ThirdPersonItemAnimAvatar;
        [Tooltip("The name of the item")]
        [SerializeField] protected string m_ItemName;
        [Tooltip("The type of item to create")]
        [SerializeField] protected EItemBuilderItemTypeForSpawner m_Type = EItemBuilderItemTypeForSpawner.Shootable;
        [Tooltip("Specifies which hadn the item should be assigned to")]
        [SerializeField] protected EItemBuilderHandAssignmentForSpawner m_HandAssignment = EItemBuilderHandAssignmentForSpawner.Right;
        [Tooltip("The local position of the item")]
        [SerializeField] protected Vector3 m_LocalPosition;
        [Tooltip("The local rotation of the item")]
        [SerializeField] protected Vector3 m_LocalRotation;
        #endregion

        #region Exposed Properties
        public ItemType ItemType { get { return m_ItemType; } }
        public GameObject Base { get { return m_Base; } }
        public ItemPickup MyItemPickup { get { return m_ItemPickup; } }
        public int AnimatorItemID { get { return m_AnimatorItemID; } }
        public RuntimeAnimatorController ThirdPersonItemAnimator { get { return m_ThirdPersonItemAnimator; } }
        public Avatar ThirdPersonItemAnimAvatar { get { return m_ThirdPersonItemAnimAvatar; } }
        public string ItemName { get { return m_ItemName; } }
        public EItemBuilderItemTypeForSpawner Type { get { return m_Type; } }
        public EItemBuilderHandAssignmentForSpawner HandAssignment { get { return m_HandAssignment; } }
        public Vector3 LocalPosition { get { return m_LocalPosition; } }
        public Vector3 LocalRotation { get { return m_LocalRotation; } }
        #endregion
    }
    #endregion

    [CreateAssetMenu(menuName = "UtilitiesAndHelpersForUCC/CharacterSpawner/AddableItemsForSpawnerData")]
    public class AddableItemsForSpawnerObject : ScriptableObject
    {
        public List<AddableItemForSpawner> AddableItems = new List<AddableItemForSpawner>();
    }
}