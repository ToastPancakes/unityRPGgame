using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment_UI : MonoBehaviour
{
    Equipment_Inventory inventory;
    public Transform itemsParent;
    Equipment_Slot[] slots;
    // Start is called before the first frame update
    void Start()
    {
        inventory = Equipment_Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<Equipment_Slot>();
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddEquipment(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
