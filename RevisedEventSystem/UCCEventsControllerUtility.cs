using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController;
using Opsive.UltimateCharacterController.Character.Abilities;
using Opsive.UltimateCharacterController.Inventory;
using Opsive.UltimateCharacterController.Items;
using Opsive.UltimateCharacterController.Character;
using Opsive.UltimateCharacterController.Items.Actions;
using Opsive.UltimateCharacterController.Events;

namespace UtilitiesAndHelpersForUCC
{
    public static class UCCEventsControllerUtility
    {
        #region OnItemTryReload
        public static string LookupStr_OnItemTryReload = "OnItemTryReload";

        /// <summary>
        /// For Event: OnItemTryReload. Tries to reload the item with the specified ItemType.
        /// </summary>
        public static void RegisterOnItemTryReload(Object caller, System.Action<int, ItemType, bool, bool> handler) =>
            EventHandler.RegisterEvent<int, ItemType, bool, bool>(caller, LookupStr_OnItemTryReload, handler);
        /// <summary>
        /// For Event: OnItemTryReload. Tries to reload the item with the specified ItemType.
        /// </summary>
        public static void UnregisterOnItemTryReload(Object caller, System.Action<int, ItemType, bool, bool> handler) =>
            EventHandler.UnregisterEvent<int, ItemType, bool, bool>(caller, LookupStr_OnItemTryReload, handler);

        /// <summary>
        /// For Event: OnItemTryReload. Tries to reload the item with the specified ItemType.
        /// </summary>
        /// <param name="slotID">The SlotID of the item trying to reload.</param>
        /// <param name="itemType">The ItemType which should be reloaded.</param>
        /// <param name="immediateReload">Should the item be reloaded immediately?</param>
        /// <param name="equipCheck">Should the equipped items be checked.</param>
        public static void CallOnItemTryReload(Object caller, int slotID, ItemType itemType, bool immediateReload, bool equipCheck) =>
            EventHandler.ExecuteEvent<int, ItemType, bool, bool>(caller, LookupStr_OnItemTryReload, slotID, itemType, immediateReload, equipCheck);
        #endregion

        #region OnAbilityWillEquipItem
        public static string LookupStr_OnAbilityWillEquipItem = "OnAbilityWillEquipItem";

        /// <summary>
        /// For Event: OnAbilityWillEquipItem. The specified item will be equipped.
        /// </summary>
        public static void RegisterOnAbilityWillEquipItem(Object caller, System.Action<Item, int> handler) =>
            EventHandler.RegisterEvent<Item, int>(caller, LookupStr_OnAbilityWillEquipItem, handler);

        /// <summary>
        /// For Event: OnAbilityWillEquipItem. The specified item will be equipped.
        /// </summary>
        public static void UnregisterOnAbilityWillEquipItem(Object caller, System.Action<Item, int> handler) =>
            EventHandler.UnregisterEvent<Item, int>(caller, LookupStr_OnAbilityWillEquipItem, handler);

        /// <summary>
        /// For Event: OnAbilityWillEquipItem. The specified item will be equipped.
        /// </summary>
        /// <param name="item">The item that will be equipped.</param>
        /// <param name="slotID">The slot that the item will occupy.</param>
        public static void CallOnAbilityWillEquipItem(Object caller, Item item, int slotID) =>
            EventHandler.ExecuteEvent<Item, int>(caller, LookupStr_OnAbilityWillEquipItem, item, slotID);
        #endregion

        #region OnAimAbilityAim
        public static string LookupStr_OnAimAbilityAim = "OnAimAbilityAim";

        /// <summary>
        /// For Event: OnAimAbilityAim. The Aim ability has started or stopped.
        /// </summary>
        public static void RegisterOnAimAbilityAim(Object caller, System.Action<bool> handler) =>
            EventHandler.RegisterEvent<bool>(caller, LookupStr_OnAimAbilityAim, handler);

        /// <summary>
        /// For Event: OnAimAbilityAim. The Aim ability has started or stopped.
        /// </summary>
        public static void UnregisterOnAimAbilityAim(Object caller, System.Action<bool> handler) =>
            EventHandler.UnregisterEvent<bool>(caller, LookupStr_OnAimAbilityAim, handler);

        /// <summary>
        /// For Event: OnAimAbilityAim. The Aim ability has started or stopped.
        /// </summary>
        /// <param name="aim">Has the Aim ability started?</param>
        public static void CallOnAimAbilityAim(Object caller, bool aim) =>
            EventHandler.ExecuteEvent<bool>(caller, LookupStr_OnAimAbilityAim, aim);
        #endregion

        #region OnDeath
        public static string LookupStr_OnDeath = "OnDeath";

        /// <summary>
        /// For Event: OnDeath. The character has died.
        /// </summary>
        public static void RegisterOnDeath(Object caller, System.Action<Vector3, Vector3, GameObject> handler) =>
            EventHandler.RegisterEvent<Vector3, Vector3, GameObject>(caller, LookupStr_OnDeath, handler);

        /// <summary>
        /// For Event: OnDeath. The character has died.
        /// </summary>
        public static void UnregisterOnDeath(Object caller, System.Action<Vector3, Vector3, GameObject> handler) =>
            EventHandler.UnregisterEvent<Vector3, Vector3, GameObject>(caller, LookupStr_OnDeath, handler);

        /// <summary>
        /// For Event: OnDeath. The character has died.
        /// </summary>
        /// <param name="position">The position of the force.</param>
        /// <param name="force">The amount of force which killed the character.</param>
        /// <param name="attacker">The GameObject that killed the character.</param>
        public static void CallOnDeath(Object caller, Vector3 position, Vector3 force, GameObject attacker) =>
            EventHandler.ExecuteEvent<Vector3, Vector3, GameObject>(caller, LookupStr_OnDeath, position, force, attacker);
        #endregion

        #region OnItemUseConsumableItemType
        public static string LookupStr_OnItemUseConsumableItemType = "OnItemUseConsumableItemType";

        /// <summary>
        /// For Event: OnItemUseConsumableItemType. The specified consumable ItemType has been used.
        /// </summary>
        public static void RegisterOnItemUseConsumableItemType(Object caller, System.Action<Item, ItemType, float> handler) =>
            EventHandler.RegisterEvent<Item, ItemType, float>(caller, LookupStr_OnItemUseConsumableItemType, handler);

        /// <summary>
        /// For Event: OnItemUseConsumableItemType. The specified consumable ItemType has been used.
        /// </summary>
        public static void UnregisterOnItemUseConsumableItemType(Object caller, System.Action<Item, ItemType, float> handler) =>
            EventHandler.UnregisterEvent<Item, ItemType, float>(caller, LookupStr_OnItemUseConsumableItemType, handler);

        /// <summary>
        /// For Event: OnItemUseConsumableItemType. The specified consumable ItemType has been used.
        /// </summary>
        /// <param name="item">The Item that has been used.</param>
        /// <param name="itemType">The ItemType that has been used.</param>
        /// <param name="count">The remaining amount of the specified ItemType.</param>
        public static void CallOnItemUseConsumableItemType(Object caller, Item item, ItemType itemType, float count) =>
            EventHandler.ExecuteEvent<Item, ItemType, float>(caller, LookupStr_OnItemUseConsumableItemType, item, itemType, count);
        #endregion

        #region OnInventoryEquipItem
        public static string LookupStr_OnInventoryEquipItem = "OnInventoryEquipItem";

        /// <summary>
        /// For Event: OnInventoryEquipItem. An item has been equipped.
        /// </summary>
        public static void RegisterOnInventoryEquipItem(Object caller, System.Action<Item, int> handler) =>
            EventHandler.RegisterEvent<Item, int>(caller, LookupStr_OnInventoryEquipItem, handler);

        /// <summary>
        /// For Event: OnInventoryEquipItem. An item has been equipped.
        /// </summary>
        public static void UnregisterOnInventoryEquipItem(Object caller, System.Action<Item, int> handler) =>
            EventHandler.UnregisterEvent<Item, int>(caller, LookupStr_OnInventoryEquipItem, handler);

        /// <summary>
        /// For Event: OnInventoryEquipItem. An item has been equipped.
        /// </summary>
        /// <param name="item">The equipped item.</param>
        /// <param name="slotID">The slot that the item now occupies.</param>
        public static void CallOnInventoryEquipItem(Object caller, Item item, int slotID) =>
            EventHandler.ExecuteEvent<Item, int>(caller, LookupStr_OnInventoryEquipItem, item, slotID);
        #endregion

        #region OnInventoryUnequipItem
        public static string LookupStr_OnInventoryUnequipItem = "OnInventoryUnequipItem";

        /// <summary>
        /// For Event: OnInventoryUnequipItem. An item has been unequipped.
        /// </summary>
        public static void RegisterOnInventoryUnequipItem(Object caller, System.Action<Item, int> handler) =>
            EventHandler.RegisterEvent<Item, int>(caller, LookupStr_OnInventoryUnequipItem, handler);

        /// <summary>
        /// For Event: OnInventoryUnequipItem. An item has been unequipped.
        /// </summary>
        public static void UnregisterOnInventoryUnequipItem(Object caller, System.Action<Item, int> handler) =>
            EventHandler.UnregisterEvent<Item, int>(caller, LookupStr_OnInventoryUnequipItem, handler);

        /// <summary>
        /// For Event: OnInventoryUnequipItem. An item has been unequipped.
        /// </summary>
        /// <param name="item">The item that was unequipped.</param>
        /// <param name="slotID">The slot that the item was unequipped from.</param>
        public static void CallOnInventoryUnequipItem(Object caller, Item item, int slotID) =>
            EventHandler.ExecuteEvent<Item, int>(caller, LookupStr_OnInventoryUnequipItem, item, slotID);
        #endregion

    }
}