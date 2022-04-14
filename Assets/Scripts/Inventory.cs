using System.Collections.Generic;
using System.Linq;
public class Inventory
{
    Dictionary<EquipSlots,Item> equippedItems = new Dictionary<EquipSlots,Item>();
    List<Item> unequippedItems = new List<Item>();
    readonly ICharacter character;

    public Inventory(ICharacter chara){
        character = chara;
    }

    public void EquipItem(Item item){
        if (equippedItems.ContainsKey(item.EquipSlot))
            unequippedItems.Add(equippedItems[item.EquipSlot]);
        equippedItems[item.EquipSlot] = item;

        character.OnItemEquipped(item);
    }

    public Item GetItem(EquipSlots equipSlot){
        if(equippedItems.ContainsKey(equipSlot)){
            return equippedItems[equipSlot];
        }
        return null;
    }

    public int GetTotalArmor(){
        int totalArmor = equippedItems.Values.Sum(t => t.Armor);
        return totalArmor;
    }
}