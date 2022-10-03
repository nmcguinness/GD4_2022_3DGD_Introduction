using System.Collections.Generic;
using UnityEngine;

namespace GD
{
    /// <summary>
    /// Maintains a list of the  items held by the player. An InventoryItem is a simple class
    /// gathering together the BaseObjectData, Amount, and Capacity that can be stored for that ConsumableObjectData.
    /// </summary>
    [CreateAssetMenu(fileName = "InventoryData", menuName = "GD/Scriptable Objects/Game/Objects/Inventory")]
    public class InventoryData : ScriptableGameObject
    {
        [SerializeField]
        public List<InventoryItem> Items;

        [SerializeField]
        private GameEvent OnAdd; //raised whenever we increment the count for an item (e.g. health)

        [SerializeField]
        private GameEvent OnRemove; //raised whenever we decrement the count for an item (e.g. health)

        [SerializeField]
        private GameEvent OnReset; //raised whenever we decrement the count for an inventory item (e.g. health)

        public void AddItem(BaseObjectData baseObjectData)
        {
            //find the inventory slot for the item
            var index = Items.FindIndex(inventoryItem => inventoryItem.BaseObjectData == baseObjectData);

            //update
            if (index != -1)
                Items[index].ChangeAmount(1);
            else
                Items.Add(new InventoryItem(baseObjectData, 1, 100));

            //notify listeners
            OnAdd?.Raise();
        }

        public void RemoveItem(BaseObjectData baseObjectData)
        {
            //find the inventory slot for the item
            var index = Items.FindIndex(inventoryItem => inventoryItem.BaseObjectData == baseObjectData);

            //update
            if (index != -1)
                Items[index].ChangeAmount(-1);

            //notify listeners
            OnRemove?.Raise();
        }

        public void ResetItems()
        {
            Items.Clear();

            //notify listeners
            OnReset?.Raise();
        }
    }

    [System.Serializable]
    public class InventoryItem
    {
        public BaseObjectData BaseObjectData;
        public int Amount;
        public int MaxAmount;

        public InventoryItem(BaseObjectData baseObjectData, int amount, int maxAmount)
        {
            BaseObjectData = baseObjectData;
            Amount = amount;
            MaxAmount = maxAmount;
        }

        public void ChangeAmount(int delta)
        {
            int newAmount = Amount + delta;
            if (newAmount < MaxAmount && newAmount >= 0)
                Amount = newAmount;

            //TODO - monitor upper limit on amount and respond accordingly
            //else if (newAmount >= MaxAmount)
            //    Debug.Log(" >= max");
            //else
            //    Debug.Log("< 0");
        }
    }
}