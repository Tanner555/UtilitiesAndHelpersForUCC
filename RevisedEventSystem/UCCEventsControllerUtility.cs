﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController;
using Opsive.UltimateCharacterController.Character.Abilities;
using Opsive.UltimateCharacterController.Inventory;
using Opsive.UltimateCharacterController.Items;
using Opsive.UltimateCharacterController.Character;
//using Opsive.UltimateCharacterController.Items.Actions;
//using Opsive.UltimateCharacterController.Events;
//using Opsive.UltimateCharacterController.Game;
//using Opsive.UltimateCharacterController.Motion;
//using Opsive.UltimateCharacterController.Utility;
using Opsive.Shared.Events;
using Opsive.Shared.Game;
using Opsive.Shared.Utility;
using Abilities = Opsive.UltimateCharacterController.Character.Abilities;

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

        #region OnAnimatorItemReloadEvents
        #region OnAnimatorItemReload
        public static string LookupStr_OnAnimatorItemReload = "OnAnimatorItemReload";

        /// <summary>
        /// For Event: OnAnimatorItemReload. The animation has reloaded all of the items.
        /// </summary>
        public static void RegisterOnAnimatorItemReload(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnAnimatorItemReload, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReload. The animation has reloaded all of the items.
        /// </summary>
        public static void UnregisterOnAnimatorItemReload(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnAnimatorItemReload, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReload. The animation has reloaded all of the items.
        /// </summary>
        public static void CallOnAnimatorItemReload(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnAnimatorItemReload);
        #endregion

        #region OnAnimatorItemReloadComplete
        public static string LookupStr_OnAnimatorItemReloadComplete = "OnAnimatorItemReloadComplete";

        /// <summary>
        /// For Event: OnAnimatorItemReloadComplete. The reload animation has completed for all of the items.
        /// </summary>
        public static void RegisterOnAnimatorItemReloadComplete(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnAnimatorItemReloadComplete, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadComplete. The reload animation has completed for all of the items.
        /// </summary>
        public static void UnregisterOnAnimatorItemReloadComplete(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnAnimatorItemReloadComplete, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadComplete. The reload animation has completed for all of the items.
        /// </summary>
        public static void CallOnAnimatorItemReloadComplete(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnAnimatorItemReloadComplete);
        #endregion

        #region OnAnimatorItemReloadFirstSlot
        public static string LookupStr_OnAnimatorItemReloadFirstSlot = "OnAnimatorItemReloadFirstSlot";

        /// <summary>
        /// For Event: OnAnimatorItemReloadFirstSlot. The animation has reloaded the first item slot.
        /// </summary>
        public static void RegisterOnAnimatorItemReloadFirstSlot(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnAnimatorItemReloadFirstSlot, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadFirstSlot. The animation has reloaded the first item slot.
        /// </summary>
        public static void UnregisterOnAnimatorItemReloadFirstSlot(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnAnimatorItemReloadFirstSlot, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadFirstSlot. The animation has reloaded the first item slot.
        /// </summary>
        public static void CallOnAnimatorItemReloadFirstSlot(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnAnimatorItemReloadFirstSlot);
        #endregion

        #region OnAnimatorItemReloadSecondSlot
        public static string LookupStr_OnAnimatorItemReloadSecondSlot = "OnAnimatorItemReloadSecondSlot";

        /// <summary>
        /// For Event: OnAnimatorItemReloadSecondSlot. The animation has reloaded the second item slot.
        /// </summary>
        public static void RegisterOnAnimatorItemReloadSecondSlot(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnAnimatorItemReloadSecondSlot, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadSecondSlot. The animation has reloaded the second item slot.
        /// </summary>
        public static void UnregisterOnAnimatorItemReloadSecondSlot(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnAnimatorItemReloadSecondSlot, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadSecondSlot. The animation has reloaded the second item slot.
        /// </summary>
        public static void CallOnAnimatorItemReloadSecondSlot(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnAnimatorItemReloadSecondSlot);
        #endregion

        #region OnAnimatorItemReloadThirdSlot
        public static string LookupStr_OnAnimatorItemReloadThirdSlot = "OnAnimatorItemReloadThirdSlot";

        /// <summary>
        /// For Event: OnAnimatorItemReloadThirdSlot. The animation has reloaded the third item slot.
        /// </summary>
        public static void RegisterOnAnimatorItemReloadThirdSlot(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnAnimatorItemReloadThirdSlot, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadThirdSlot. The animation has reloaded the third item slot.
        /// </summary>
        public static void UnregisterOnAnimatorItemReloadThirdSlot(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnAnimatorItemReloadThirdSlot, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadThirdSlot. The animation has reloaded the third item slot.
        /// </summary>
        public static void CallOnAnimatorItemReloadThirdSlot(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnAnimatorItemReloadThirdSlot);
        #endregion

        #region OnAnimatorItemReloadCompleteFirstSlot
        public static string LookupStr_OnAnimatorItemReloadCompleteFirstSlot = "OnAnimatorItemReloadCompleteFirstSlot";

        /// <summary>
        /// For Event: OnAnimatorItemReloadCompleteFirstSlot. The reload animation has completed for the first item slot.
        /// </summary>
        public static void RegisterOnAnimatorItemReloadCompleteFirstSlot(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnAnimatorItemReloadCompleteFirstSlot, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadCompleteFirstSlot. The reload animation has completed for the first item slot.
        /// </summary>
        public static void UnregisterOnAnimatorItemReloadCompleteFirstSlot(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnAnimatorItemReloadCompleteFirstSlot, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadCompleteFirstSlot. The reload animation has completed for the first item slot.
        /// </summary>
        public static void CallOnAnimatorItemReloadCompleteFirstSlot(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnAnimatorItemReloadCompleteFirstSlot);
        #endregion

        #region OnAnimatorItemReloadCompleteSecondSlot
        public static string LookupStr_OnAnimatorItemReloadCompleteSecondSlot = "OnAnimatorItemReloadCompleteSecondSlot";

        /// <summary>
        /// For Event: OnAnimatorItemReloadCompleteSecondSlot. The reload animation has completed for the second item slot.
        /// </summary>
        public static void RegisterOnAnimatorItemReloadCompleteSecondSlot(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnAnimatorItemReloadCompleteSecondSlot, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadCompleteSecondSlot. The reload animation has completed for the second item slot.
        /// </summary>
        public static void UnregisterOnAnimatorItemReloadCompleteSecondSlot(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnAnimatorItemReloadCompleteSecondSlot, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadCompleteSecondSlot. The reload animation has completed for the second item slot.
        /// </summary>
        public static void CallOnAnimatorItemReloadCompleteSecondSlot(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnAnimatorItemReloadCompleteSecondSlot);
        #endregion

        #region OnAnimatorItemReloadCompleteThirdSlot
        public static string LookupStr_OnAnimatorItemReloadCompleteThirdSlot = "OnAnimatorItemReloadCompleteThirdSlot";

        /// <summary>
        /// For Event: OnAnimatorItemReloadCompleteThirdSlot. The reload animation has completed for the third item slot.
        /// </summary>
        public static void RegisterOnAnimatorItemReloadCompleteThirdSlot(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnAnimatorItemReloadCompleteThirdSlot, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadCompleteThirdSlot. The reload animation has completed for the third item slot.
        /// </summary>
        public static void UnregisterOnAnimatorItemReloadCompleteThirdSlot(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnAnimatorItemReloadCompleteThirdSlot, handler);

        /// <summary>
        /// For Event: OnAnimatorItemReloadCompleteThirdSlot. The reload animation has completed for the third item slot.
        /// </summary>
        public static void CallOnAnimatorItemReloadCompleteThirdSlot(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnAnimatorItemReloadCompleteThirdSlot);
        #endregion
        #endregion

        #region OnAnimatorWillSnap
        public static string LookupStr_OnAnimatorWillSnap = "OnAnimatorWillSnap";

        /// <summary>
        /// For Event: OnAnimatorWillSnap. Immediately position the IK limbs.
        /// </summary>
        public static void RegisterOnAnimatorWillSnap(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnAnimatorWillSnap, handler);

        /// <summary>
        /// For Event: OnAnimatorWillSnap. Immediately position the IK limbs.
        /// </summary>
        public static void UnregisterOnAnimatorWillSnap(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnAnimatorWillSnap, handler);


        /// <summary>
        /// For Event: OnAnimatorWillSnap. Immediately position the IK limbs.
        /// </summary>
        public static void CallOnAnimatorWillSnap(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnAnimatorWillSnap);
        #endregion

        #region OnAnimatorSnapped
        public static string LookupStr_OnAnimatorSnapped = "OnAnimatorSnapped";

        /// <summary>
        /// For Event: OnAnimatorSnapped. The animator has snapped into position.
        /// </summary>
        public static void RegisterOnAnimatorSnapped(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnAnimatorSnapped, handler);

        /// <summary>
        /// For Event: OnAnimatorSnapped. The animator has snapped into position.
        /// </summary>
        public static void UnregisterOnAnimatorSnapped(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnAnimatorSnapped, handler);

        /// <summary>
        /// For Event: OnAnimatorSnapped. The animator has snapped into position.
        /// </summary>
        public static void CallOnAnimatorSnapped(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnAnimatorSnapped);
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

        #region OnUseAbilityStart
        public static string LookupStr_OnUseAbilityStart = "OnUseAbilityStart";

        /// <summary>
        /// For Event: OnUseAbilityStart. The Use ability has started or stopped using an item.
        /// </summary>
        public static void RegisterOnUseAbilityStart(Object caller, System.Action<bool, Abilities.Items.Use> handler) =>
            EventHandler.RegisterEvent<bool, Abilities.Items.Use>(caller, LookupStr_OnUseAbilityStart, handler);

        /// <summary>
        /// For Event: OnUseAbilityStart. The Use ability has started or stopped using an item.
        /// </summary>
        public static void UnregisterOnUseAbilityStart(Object caller, System.Action<bool, Abilities.Items.Use> handler) =>
            EventHandler.UnregisterEvent<bool, Abilities.Items.Use>(caller, LookupStr_OnUseAbilityStart, handler);

        /// <summary>
        /// For Event: OnUseAbilityStart. The Use ability has started or stopped using an item.
        /// </summary>
        /// <param name="start">Has the Use ability started?</param>
        /// <param name="useAbility">The Use ability that has started or stopped.</param>
        public static void CallOnUseAbilityStart(Object caller, bool start, Abilities.Items.Use useAbility) =>
            EventHandler.ExecuteEvent<bool, Abilities.Items.Use>(caller, LookupStr_OnUseAbilityStart, start, useAbility);
        #endregion

        #region OnAddSecondaryForce
        public static string LookupStr_OnAddSecondaryForce = "OnAddSecondaryForce";

        /// <summary>
        /// For Event: OnAddSecondaryForce. Adds a positional and rotational force to the ik target.
        /// </summary>
        public static void RegisterOnAddSecondaryForce(Object caller, System.Action<int, Vector3, Vector3> handler) =>
            EventHandler.RegisterEvent<int, Vector3, Vector3>(caller, LookupStr_OnAddSecondaryForce, handler);

        /// <summary>
        /// For Event: OnAddSecondaryForce. Adds a positional and rotational force to the ik target.
        /// </summary>
        public static void UnregisterOnAddSecondaryForce(Object caller, System.Action<int, Vector3, Vector3> handler) =>
            EventHandler.UnregisterEvent<int, Vector3, Vector3>(caller, LookupStr_OnAddSecondaryForce, handler);

        /// <summary>
        /// For Event: OnAddSecondaryForce. Adds a positional and rotational force to the ik target.
        /// </summary>
        /// <param name="slotID">The Slot ID that is adding the secondary force.</param>
        /// <param name="positionalForce">The positional force to add.</param>
        /// <param name="rotationalForce">The rotational force to add.</param>
        public static void CallOnAddSecondaryForce(Object caller, int slotID, Vector3 positionalForce, Vector3 rotationalForce) =>
            EventHandler.ExecuteEvent<int, Vector3, Vector3>(caller, LookupStr_OnAddSecondaryForce, slotID, positionalForce, rotationalForce);
        #endregion

        #region OnObjectImpact
        public static string LookupStr_OnObjectImpact = "OnObjectImpact";

        /// <summary>
        /// For Event: OnObjectImpact. The object has been impacted with another object.
        /// </summary>
        public static void RegisterOnObjectImpact(Object caller, Action<float, Vector3, Vector3, GameObject, Collider> handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnObjectImpact, handler);

        /// <summary>
        /// For Event: OnObjectImpact. The object has been impacted with another object.
        /// </summary>
        public static void UnregisterOnObjectImpact(Object caller, Action<float, Vector3, Vector3, GameObject, Collider> handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnObjectImpact, handler);

        /// <summary>
        /// For Event: OnObjectImpact. The object has been impacted with another object.
        /// </summary>
        /// <param name="amount">The amount of damage taken.</param>
        /// <param name="position">The position of the damage.</param>
        /// <param name="forceDirection">The direction that the object took damage from.</param>
        /// <param name="attacker">The GameObject that did the damage.</param>
        /// <param name="hitCollider">The Collider that was hit.</param>
        public static void CallOnObjectImpact(Object caller, float amount, Vector3 position, Vector3 forceDirection, GameObject attacker, Collider hitCollider) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnObjectImpact, amount, position, forceDirection, attacker, hitCollider);
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

        #region OnItemPickupStartPickup
        public static string LookupStr_OnItemPickupStartPickup = "OnItemPickupStartPickup";

        /// <summary>
        /// For Event: OnItemPickupStartPickup. The ItemPickup component is starting to pick up ItemTypes.
        /// </summary>
        public static void RegisterOnItemPickupStartPickup(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnItemPickupStartPickup, handler);

        /// <summary>
        /// For Event: OnItemPickupStartPickup. The ItemPickup component is starting to pick up ItemTypes.
        /// </summary>
        public static void UnregisterOnItemPickupStartPickup(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnItemPickupStartPickup, handler);

        /// <summary>
        /// For Event: OnItemPickupStartPickup. The ItemPickup component is starting to pick up ItemTypes.
        /// </summary>
        public static void CallOnItemPickupStartPickup(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnItemPickupStartPickup);
        #endregion

        #region OnInventoryEvents
        #region OnInventoryPickupItemType
        public static string LookupStr_OnInventoryPickupItemType = "OnInventoryPickupItemType";

        /// <summary>
        /// For Event: OnInventoryPickupItemType. An ItemType has been picked up within the inventory.
        /// </summary>
        public static void RegisterOnInventoryPickupItemType(Object caller, System.Action<ItemType, float, bool, bool> handler) =>
            EventHandler.RegisterEvent<ItemType, float, bool, bool>(caller, LookupStr_OnInventoryPickupItemType, handler);

        /// <summary>
        /// For Event: OnInventoryPickupItemType. An ItemType has been picked up within the inventory.
        /// </summary>
        public static void UnregisterOnInventoryPickupItemType(Object caller, System.Action<ItemType, float, bool, bool> handler) =>
            EventHandler.UnregisterEvent<ItemType, float, bool, bool>(caller, LookupStr_OnInventoryPickupItemType, handler);

        /// <summary>
        /// For Event: OnInventoryPickupItemType. An ItemType has been picked up within the inventory.
        /// </summary>
        /// <param name="itemType">The ItemType that has been equipped.</param>
        /// <param name="amount">The amount of ItemType picked up.</param>
        /// <param name="immediatePickup">Was the item be picked up immediately?</param>
        /// <param name="forceEquip">Should the item be force equipped?</param>
        public static void CallOnInventoryPickupItemType(Object caller, ItemType itemType, float amount, bool immediatePickup, bool forceEquip) =>
            EventHandler.ExecuteEvent<ItemType, float, bool, bool>(caller, LookupStr_OnInventoryPickupItemType, itemType, amount, immediatePickup, forceEquip);
        #endregion

        #region OnInventoryPickupItem
        public static string LookupStr_OnInventoryPickupItem = "OnInventoryPickupItem";

        /// <summary>
        /// For Event: OnInventoryPickupItem. An item has been picked up within the inventory. Determine if the ability should start.
        /// </summary>
        public static void RegisterOnInventoryPickupItem(Object caller, System.Action<Item, float, bool, bool> handler)
        {
            EventHandler.RegisterEvent<Item, float, bool, bool>(caller, LookupStr_OnInventoryPickupItem, handler);
        }

        /// <summary>
        /// For Event: OnInventoryPickupItem. An item has been picked up within the inventory. Determine if the ability should start.
        /// </summary>
        public static void UnregisterOnInventoryPickupItem(Object caller, System.Action<Item, float, bool, bool> handler)
        {
            EventHandler.UnregisterEvent<Item, float, bool, bool>(caller, LookupStr_OnInventoryPickupItem, handler);
        }

        /// <summary>
        /// For Event: OnInventoryPickupItem. An item has been picked up within the inventory. Determine if the ability should start.
        /// </summary>
        /// <param name="item">The item that has been equipped.</param>
        /// <param name="count">The amount of item picked up.</param>
        /// <param name="immediatePickup">Was the item be picked up immediately?</param>
        /// <param name="forceEquip">Should the item be force equipped?</param>
        public static void CallOnInventoryPickupItem(Object caller, Item item, float count, bool immediatePickup, bool forceEquip)
        {
            EventHandler.ExecuteEvent<Item, float, bool, bool>(caller, LookupStr_OnInventoryPickupItem, item, count, immediatePickup, forceEquip);
        }
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

        #region OnInventoryAddItem
        public static string LookupStr_OnInventoryAddItem = "OnInventoryAddItem";

        /// <summary>
        /// For Event: OnInventoryAddItem. The inventory has added the specified item.
        /// </summary>
        public static void RegisterOnInventoryAddItem(Object caller, System.Action<Item> handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnInventoryAddItem, handler);

        /// <summary>
        /// For Event: OnInventoryAddItem. The inventory has added the specified item.
        /// </summary>
        public static void UnregisterOnInventoryAddItem(Object caller, System.Action<Item> handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnInventoryAddItem, handler);

        /// <summary>
        /// For Event: OnInventoryAddItem. The inventory has added the specified item.
        /// </summary>
        /// <param name="item">The item that was added.</param>
        public static void CallOnInventoryAddItem(Object caller, Item item) =>
            EventHandler.ExecuteEvent<Item>(caller, LookupStr_OnInventoryAddItem, item);
        #endregion

        #region OnInventoryRemoveItem
        public static string LookupStr_OnInventoryRemoveItem = "OnInventoryRemoveItem";

        /// <summary>
        /// For Event: OnInventoryRemoveItem. The inventory has removed the specified item.
        /// </summary>
        public static void RegisterOnInventoryRemoveItem(Object caller, System.Action<Item, int> handler) =>
            EventHandler.RegisterEvent<Item, int>(caller, LookupStr_OnInventoryRemoveItem, handler);

        /// <summary>
        /// For Event: OnInventoryRemoveItem. The inventory has removed the specified item.
        /// </summary>
        public static void UnregisterOnInventoryRemoveItem(Object caller, System.Action<Item, int> handler) =>
            EventHandler.UnregisterEvent<Item, int>(caller, LookupStr_OnInventoryRemoveItem, handler);

        /// <summary>
        /// For Event: OnInventoryRemoveItem. The inventory has removed the specified item.
        /// </summary>
        /// <param name="item">The item that was removed.</param>
        /// <param name="slotID">The slot that the item was removed from.</param>
        public static void CallOnInventoryRemoveItem(Object caller, Item item, int slotID) =>
            EventHandler.ExecuteEvent<Item, int>(caller, LookupStr_OnInventoryRemoveItem, item, slotID);
        #endregion

        #region OnInventoryUseItemType
        public static string LookupStr_OnInventoryUseItemType = "OnInventoryUseItemType";

        /// <summary>
        /// For Event: OnInventoryUseItemType. The specified ItemType has been used.
        /// </summary>
        public static void RegisterOnInventoryUseItemType(Object caller, System.Action<ItemType, float> handler)
        {
            EventHandler.RegisterEvent<ItemType, float>(caller, LookupStr_OnInventoryUseItemType, handler);
        }

        /// <summary>
        /// For Event: OnInventoryUseItemType. The specified ItemType has been used.
        /// </summary>
        public static void UnregisterOnInventoryUseItemType(Object caller, System.Action<ItemType, float> handler)
        {
            EventHandler.UnregisterEvent<ItemType, float>(caller, LookupStr_OnInventoryUseItemType, handler);
        }

        /// <summary>
        /// For Event: OnInventoryUseItemType. The specified ItemType has been used.
        /// </summary>
        /// <param name="itemType">The ItemType that has been used.</param>
        /// <param name="count">The remaining amount of the specified ItemType.</param>
        public static void CallOnInventoryUseItemType(Object caller, ItemType itemType, float count)
        {
            EventHandler.ExecuteEvent<ItemType, float>(caller, LookupStr_OnInventoryUseItemType, itemType, count);
        }
        #endregion

        #endregion

        #region OnRespawn
        public static string LookupStr_OnRespawn = "OnRespawn";

        /// <summary>
        /// For Event: OnRespawn. The character has respawned. Start moving again.
        /// </summary>
        public static void RegisterOnRespawn(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnRespawn, handler);

        /// <summary>
        /// For Event: OnRespawn. The character has respawned. Start moving again.
        /// </summary>
        public static void UnregisterOnRespawn(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnRespawn, handler);

        /// <summary>
        /// For Event: OnRespawn. The character has respawned. Start moving again.
        /// </summary>
        public static void CallOnRespawn(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnRespawn);
        #endregion

        #region OnHealthDamage
        public static string LookupStr_OnHealthDamage = "OnHealthDamage";

        /// <summary>
        /// For Event: OnHealthDamage. The object has taken damage.
        /// </summary>
        public static void RegisterOnHealthDamage(Object caller, Action<float, Vector3, Vector3, GameObject, Collider> handler) =>
            EventHandler.RegisterEvent<float, Vector3, Vector3, GameObject, Collider>(caller, LookupStr_OnHealthDamage, handler);

        /// <summary>
        /// For Event: OnHealthDamage. The object has taken damage.
        /// </summary>
        public static void UnregisterOnHealthDamage(Object caller, Action<float, Vector3, Vector3, GameObject, Collider> handler) =>
            EventHandler.UnregisterEvent<float, Vector3, Vector3, GameObject, Collider>(caller, LookupStr_OnHealthDamage, handler);

        /// <summary>
        /// For Event: OnHealthDamage. The object has taken damage.
        /// </summary>
        /// <param name="amount">The amount of damage taken.</param>
        /// <param name="position">The position of the damage.</param>
        /// <param name="force">The amount of force applied to the object while taking the damage.</param>
        /// <param name="attacker">The GameObject that did the damage.</param>
        /// <param name="hitCollider">The Collider that was hit.</param>
        public static void CallOnHealthDamage(Object caller, float amount, Vector3 position, Vector3 force, GameObject attacker, Collider hitCollider) =>
            EventHandler.ExecuteEvent<float, Vector3, Vector3, GameObject, Collider>(caller, LookupStr_OnHealthDamage, amount, position, force, attacker, hitCollider);
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

        #region OnAnimatorDamageVisualizationComplete
        public static string LookupStr_OnAnimatorDamageVisualizationComplete = "OnAnimatorDamageVisualizationComplete";

        /// <summary>
        /// For Event: OnAnimatorDamageVisualizationComplete. Animation event callback when the damage visualization animation has completed.
        /// </summary>
        public static void RegisterOnAnimatorDamageVisualizationComplete(Object caller, System.Action handler) =>
            EventHandler.RegisterEvent(caller, LookupStr_OnAnimatorDamageVisualizationComplete, handler);

        /// <summary>
        /// For Event: OnAnimatorDamageVisualizationComplete. Animation event callback when the damage visualization animation has completed.
        /// </summary>
        public static void UnregisterOnAnimatorDamageVisualizationComplete(Object caller, System.Action handler) =>
            EventHandler.UnregisterEvent(caller, LookupStr_OnAnimatorDamageVisualizationComplete, handler);

        /// <summary>
        /// For Event: OnAnimatorDamageVisualizationComplete. Animation event callback when the damage visualization animation has completed.
        /// </summary>
        public static void CallOnAnimatorDamageVisualizationComplete(Object caller) =>
            EventHandler.ExecuteEvent(caller, LookupStr_OnAnimatorDamageVisualizationComplete);
        #endregion

        #region OnEnableGameplayInput
        public static string LookupStr_OnEnableGameplayInput = "OnEnableGameplayInput";

        /// <summary>
        /// For Event: CallOnEnableGameplayInput.
        /// Enables or disables gameplay input. 
        /// An example of when it will not be enabled is when there is a fullscreen UI over the main camera.
        /// </summary>
        public static void RegisterOnEnableGameplayInput(Object caller, System.Action<bool> handler) =>
            EventHandler.RegisterEvent<bool>(caller, LookupStr_OnEnableGameplayInput, handler);

        /// <summary>
        /// For Event: CallOnEnableGameplayInput.
        /// Enables or disables gameplay input. 
        /// An example of when it will not be enabled is when there is a fullscreen UI over the main camera.
        /// </summary>
        public static void UnregisterOnEnableGameplayInput(Object caller, System.Action<bool> handler) =>
            EventHandler.UnregisterEvent<bool>(caller, LookupStr_OnEnableGameplayInput, handler);

        /// <summary>
        /// For Event: CallOnEnableGameplayInput.
        /// Enables or disables gameplay input. 
        /// An example of when it will not be enabled is when there is a fullscreen UI over the main camera.
        /// </summary>
        /// <param name="enable">True if the input is enabled.</param>
        public static void CallOnEnableGameplayInput(Object caller, bool enable) =>
            EventHandler.ExecuteEvent<bool>(caller, LookupStr_OnEnableGameplayInput, enable);
        #endregion

        #region OnCharacterGrounded
        public static string LookupStr_OnCharacterGrounded = "OnCharacterGrounded";

        /// <summary>
        /// For Event: OnCharacterGrounded. The character has changed grounded state.
        /// </summary>
        public static void RegisterOnCharacterGrounded(Object caller, System.Action<bool> handler) =>
            EventHandler.RegisterEvent<bool>(caller, LookupStr_OnCharacterGrounded, handler);

        /// <summary>
        /// For Event: OnCharacterGrounded. The character has changed grounded state.
        /// </summary>
        public static void UnregisterOnCharacterGrounded(Object caller, System.Action<bool> handler) =>
            EventHandler.UnregisterEvent<bool>(caller, LookupStr_OnCharacterGrounded, handler);

        /// <summary>
        /// For Event: OnCharacterGrounded. The character has changed grounded state.
        /// </summary>
        /// <param name="grounded">Is the character on the ground?</param>
        public static void CallOnCharacterGrounded(Object caller, bool grounded) =>
            EventHandler.ExecuteEvent<bool>(caller, LookupStr_OnCharacterGrounded, grounded);
        #endregion

        #region OnCharacterActivate
        public static string LookupStr_OnCharacterActivate = "OnCharacterActivate";

        /// <summary>
        /// For Event: OnCharacterActivate. The character has been activated or deactivated.
        /// </summary>
        public static void RegisterOnCharacterActivate(Object caller, System.Action<bool> handler) =>
            EventHandler.RegisterEvent<bool>(caller, LookupStr_OnCharacterActivate, handler);

        /// <summary>
        /// For Event: OnCharacterActivate. The character has been activated or deactivated.
        /// </summary>
        public static void UnregisterOnCharacterActivate(Object caller, System.Action<bool> handler) =>
            EventHandler.UnregisterEvent<bool>(caller, LookupStr_OnCharacterActivate, handler);

        /// <summary>
        /// For Event: OnCharacterActivate. The character has been activated or deactivated.
        /// </summary>
        /// <param name="enable">True if the character has been activated.</param>
        public static void CallOnCharacterActivate(Object caller, bool enable) =>
            EventHandler.ExecuteEvent<bool>(caller, LookupStr_OnCharacterActivate, enable);
        #endregion

        #region OnCharacterAttachLookSource
        public static string LookupStr_OnCharacterAttachLookSource = "OnCharacterAttachLookSource";

        /// <summary>
        /// For Event: OnCharacterAttachLookSource. A new ILookSource object has been attached to the character.
        /// </summary>
        public static void RegisterOnCharacterAttachLookSource(Object caller, System.Action<ILookSource> handler) =>
            EventHandler.RegisterEvent<ILookSource>(caller, LookupStr_OnCharacterAttachLookSource, handler);

        /// <summary>
        /// For Event: OnCharacterAttachLookSource. A new ILookSource object has been attached to the character.
        /// </summary>
        public static void UnregisterOnCharacterAttachLookSource(Object caller, System.Action<ILookSource> handler) =>
            EventHandler.UnregisterEvent<ILookSource>(caller, LookupStr_OnCharacterAttachLookSource, handler);

        /// <summary>
        /// For Event: OnCharacterAttachLookSource. A new ILookSource object has been attached to the character.
        /// </summary>
        /// <param name="lookSource">The ILookSource object attached to the character.</param>
        public static void CallOnCharacterAttachLookSource(Object caller, ILookSource lookSource) =>
            EventHandler.ExecuteEvent<ILookSource>(caller, LookupStr_OnCharacterAttachLookSource, lookSource);
        #endregion

        #region OnCameraAttachCharacter
        public static string LookupStr_OnCameraAttachCharacter = "OnCameraAttachCharacter";

        /// <summary>
        /// For Event: OnCameraAttachCharacter. Attaches the handler to the specified character.
        /// </summary>
        public static void RegisterOnCameraAttachCharacter(Object caller, System.Action<GameObject> handler) =>
            EventHandler.RegisterEvent<GameObject>(caller, LookupStr_OnCameraAttachCharacter, handler);

        /// <summary>
        /// For Event: OnCameraAttachCharacter. Attaches the handler to the specified character.
        /// </summary>
        public static void UnregisterOnCameraAttachCharacter(Object caller, System.Action<GameObject> handler) =>
            EventHandler.UnregisterEvent<GameObject>(caller, LookupStr_OnCameraAttachCharacter, handler);

        /// <summary>
        /// For Event: OnCameraAttachCharacter. Attaches the handler to the specified character.
        /// </summary>
        /// <param name="character">The character to attach the handler to.</param>
        public static void CallOnCameraAttachCharacter(Object caller, GameObject character) =>
            EventHandler.ExecuteEvent<GameObject>(caller, LookupStr_OnCameraAttachCharacter, character);
        #endregion

        #region OnCharacterChangeTimeScale
        public static string LookupStr_OnCharacterChangeTimeScale = "OnCharacterChangeTimeScale";

        /// <summary>
        /// For Event: OnCharacterChangeTimeScale. The character's local timescale has changed.
        /// </summary>
        public static void RegisterOnCharacterChangeTimeScale(Object caller, System.Action<float> handler) =>
            EventHandler.RegisterEvent<float>(caller, LookupStr_OnCharacterChangeTimeScale, handler);

        /// <summary>
        /// For Event: OnCharacterChangeTimeScale. The character's local timescale has changed.
        /// </summary>
        public static void UnregisterOnCharacterChangeTimeScale(Object caller, System.Action<float> handler) =>
            EventHandler.UnregisterEvent<float>(caller, LookupStr_OnCharacterChangeTimeScale, handler);

        /// <summary>
        /// For Event: OnCharacterChangeTimeScale. The character's local timescale has changed.
        /// </summary>
        /// <param name="timeScale">The new timescale.</param>
        public static void CallOnCharacterChangeTimeScale(Object caller, float timeScale) =>
            EventHandler.ExecuteEvent<float>(caller, LookupStr_OnCharacterChangeTimeScale, timeScale);
        #endregion
    }
}