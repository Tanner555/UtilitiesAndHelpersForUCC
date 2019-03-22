using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController;
using Opsive.UltimateCharacterController.Inventory;

namespace UtilitiesAndHelpersForUCC
{
    #region WeaponPositionClass
    [System.Serializable]
    public class LocalWeaponPositionsClass
    {
        [Tooltip("Not Needed For Data, For Easy Editor Access Only")]
        [SerializeField] public string AddableItemName;
        [Tooltip("The Third Person Controller ItemType reference")]
        [SerializeField] public ItemType m_ItemType;
        [Tooltip("The local position of the item")]
        [SerializeField] public Vector3 m_LocalPosition;
        [Tooltip("The local rotation of the item")]
        [SerializeField] public Vector3 m_LocalRotation;

    }
    #endregion

    [CreateAssetMenu(menuName = "UtilitiesAndHelpersForUCC/CharacterSpawner/LocalWeaponPositionsData")]
    public class WeaponLocalPositionsObject : ScriptableObject
    {
        public List<LocalWeaponPositionsClass> WeaponPositionsAndRotations = new List<LocalWeaponPositionsClass>();
    }
}