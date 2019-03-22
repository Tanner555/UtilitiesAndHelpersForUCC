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
        #region StringList
        public static string LookupStr_OnItemTryReload = "OnItemTryReload";
        public static string LookupStr_OnAbilityWillEquipItem = "OnAbilityWillEquipItem";
        #endregion

        #region Register / Deregister Events
        /// <summary>
        /// For Event: OnItemTryReload. Tries to reload the item with the specified ItemType.
        /// </summary>
        /// <param name="caller"></param>
        /// <param name="handler"></param>
        public static void RegisterOnItemTryReload(Object caller, System.Action<int, ItemType, bool, bool> handler) => EventHandler.RegisterEvent<int, ItemType, bool, bool>(caller, LookupStr_OnItemTryReload, handler);
        /// <summary>
        /// For Event: OnItemTryReload. Tries to reload the item with the specified ItemType.
        /// </summary>
        /// <param name="caller"></param>
        /// <param name="handler"></param>
        public static void UnregisterOnItemTryReload(Object caller, System.Action<int, ItemType, bool, bool> handler) => EventHandler.UnregisterEvent<int, ItemType, bool, bool>(caller, LookupStr_OnItemTryReload, handler);
        /// <summary>
        /// For Event: OnAbilityWillEquipItem. The specified item will be equipped.
        /// </summary>
        /// <param name="caller"></param>
        /// <param name="handler"></param>
        public static void RegisterOnAbilityWillEquipItem(Object caller, System.Action<Item, int> handler) => EventHandler.RegisterEvent<Item, int>(caller, LookupStr_OnAbilityWillEquipItem, handler);
        /// <summary>
        /// For Event: OnAbilityWillEquipItem. The specified item will be equipped.
        /// </summary>
        /// <param name="caller"></param>
        /// <param name="handler"></param>
        public static void UnregisterOnAbilityWillEquipItem(Object caller, System.Action<Item, int> handler) => EventHandler.UnregisterEvent<Item, int>(caller, LookupStr_OnAbilityWillEquipItem, handler);
        #endregion

        #region EventCalls
        /// <summary>
        /// For Event: OnItemTryReload. Tries to reload the item with the specified ItemType.
        /// </summary>
        /// <param name="caller"></param>
        /// <param name="slotID">The SlotID of the item trying to reload.</param>
        /// <param name="itemType">The ItemType which should be reloaded.</param>
        /// <param name="immediateReload">Should the item be reloaded immediately?</param>
        /// <param name="equipCheck">Should the equipped items be checked.</param>
        public static void CallOnItemTryReload(Object caller, int slotID, ItemType itemType, bool immediateReload, bool equipCheck)
        {
            EventHandler.ExecuteEvent<int, ItemType, bool, bool>(caller, LookupStr_OnItemTryReload, slotID, itemType, immediateReload, equipCheck);
        }

        /// <summary>
        /// For Event: OnAbilityWillEquipItem. The specified item will be equipped.
        /// </summary>
        /// <param name="caller"></param>
        /// <param name="item">The item that will be equipped.</param>
        /// <param name="slotID">The slot that the item will occupy.</param>
        public static void CallOnAbilityWillEquipItem(Object caller, Item item, int slotID)
        {
            EventHandler.ExecuteEvent<Item, int>(caller, LookupStr_OnAbilityWillEquipItem, item, slotID);
        }
        #endregion
    }
}