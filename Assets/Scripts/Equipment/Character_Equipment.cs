using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Equipment : MonoBehaviour
{
    public Transform itemsParent;
    Character_ESlot[] slots;
    Equipment_Manager equipmentManager;
    Equipment[] currentEquipment;
    // Start is called before the first frame update
    void Start()
    {
        equipmentManager = FindObjectOfType<Equipment_Manager>().GetComponent<Equipment_Manager>();
        slots = itemsParent.GetComponentsInChildren<Character_ESlot>();
    }

    public void UpdateUI()
    {
        currentEquipment = equipmentManager.currentEquipment;
        for (int i = 0; i < slots.Length; i++)
        {
            if (currentEquipment[i] != null)
            {
                //Debug.Log("current equipment = " + currentEquipment[i]);
                //Debug.Log("icon = " + currentEquipment[i].icon);
                //Debug.Log(equipmentManager.currentEquipment.Length);
                slots[i].AddCharacterE(currentEquipment[i]);
            }
        }
    }




}

