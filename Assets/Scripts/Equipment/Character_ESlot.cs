using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_ESlot : MonoBehaviour
{
    Equipment item;
    public Image icon;
    public Button unequipButton;
    public void AddCharacterE(Equipment newItem)
    {
        Debug.Log("slot got new item");
        item = newItem;
        icon.sprite = newItem.icon;
        icon.enabled = true;
        unequipButton.interactable = true;
        OnAddEquipment();
    }

    public void removeItem()
    {
        icon.enabled = false;
        FindObjectOfType<Equipment_Manager>().Unequip((int)item.equipSlot);
        icon.sprite = null;
        OnRemoveEquipment();
    }

    public void OnAddEquipment()
    {
        Debug.Log("player strength = " + Player_Stat_Controller.strength);
        Player_Stat_Controller.endurance += item.endurance;
        Player_Stat_Controller.strength += item.strength;
        Player_Stat_Controller.intelligence += item.intelligence;
        Player_Stat_Controller.dexterity += item.dexterity;
        Player_Stat_Controller.magicEndurance += item.magicEndurance;
        Debug.Log("player strength = " + Player_Stat_Controller.strength);
    }

    public void OnRemoveEquipment()
    {
        Player_Stat_Controller.endurance -= item.endurance;
        Player_Stat_Controller.strength -= item.strength;
        Player_Stat_Controller.intelligence -= item.intelligence;
        Player_Stat_Controller.dexterity -= item.dexterity;
        Player_Stat_Controller.magicEndurance -= item.magicEndurance;
    }
}
