using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory
{
    Dictionary<EquipSlots, Item> _equippedItem = new Dictionary<EquipSlots, Item>();
    List<Item> _unequippedItems = new List<Item>();

    public void EquipItem(Item item)
    {
        if (_equippedItem.ContainsKey(item.EquipSlot))
            _unequippedItems.Add(_equippedItem[item.EquipSlot]);

        _equippedItem[item.EquipSlot] = item;
    }

    public Item GetItem(EquipSlots equipSlot)
    {
        if (_equippedItem.ContainsKey(equipSlot))
            return _equippedItem[equipSlot];
        return null;
    }

    public int GetTotalArmor()
    {
        int totalArmor = _equippedItem.Values.Sum(t => t.Armor);
        return totalArmor;
    }
}
