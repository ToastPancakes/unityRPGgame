﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment_Pickup : Interactable
{
	public Equipment item;   // Item to put in the inventory on pickup

	// When the player interacts with the item
	public override void Interact()
	{
		base.Interact();

		PickUp();   // Pick it up!
	}

	// Pick up the item
	void PickUp()
	{
		Debug.Log("Picking up " + item.name);
		bool wasPickedUp = Equipment_Inventory.instance.Add(item);    // Add to inventory

		// If successfully picked up
		if (wasPickedUp)
			Destroy(gameObject);    // Destroy item from scene
	}


}
