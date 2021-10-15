using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* An Item that can be equipped. */

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item
{



	public EquipmentSlot equipSlot; // Slot to store equipment in

    public int endurance;
    public int strength;
    public int dexterity;
    public int intelligence;
    public int magicEndurance;
    // When pressed in inventory
    public override void Use()
	{
		base.Use();
		Equipment_Manager.instance.Equip(this);  // Equip it
		Equipment_Inventory.instance.Remove(this);
	}

}

public enum EquipmentSlot { Head, Chest, Legs, Weapon, Shield }
