using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equipment_Slot : MonoBehaviour
{
    Equipment item;
    public Image icon;
    public Button removeButton;
    public void AddEquipment(Equipment newItem)
    {
        Debug.Log("slot got new item");
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        removeButton.interactable = true;
    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

    public void OnRemoveButton()
    {
        Equipment_Inventory.instance.Remove(item);
        Debug.Log("OnRemoveButton is being called");
    }


    public void useItem()
    {
        if (item != null)
        {
            item.Use();
        }
    }
}
