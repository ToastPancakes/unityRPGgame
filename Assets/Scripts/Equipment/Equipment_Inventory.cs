using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment_Inventory : MonoBehaviour
{

	#region Singleton

	public static Equipment_Inventory instance;

	void Awake()
	{
		if (instance != null)
		{
			Debug.LogWarning("More than one instance of Inventory found!");
			return;
		}

		instance = this;
	}

	#endregion

	// Callback which is triggered when
	// an item gets added/removed.
	public delegate void OnItemChanged();
	public OnItemChanged onItemChangedCallback;

	public int space = 15;  // Amount of slots in inventory

	// Current list of items in inventory
	public List<Equipment> items = new List<Equipment>();

	// Add a new item. If there is enough room we
	// return true. Else we return false.
	public bool Add(Equipment item)
	{
		Debug.Log("item got added");
		// Don't do anything if it's a default item
		if (!item.isDefaultItem)
		{
			// Check if out of space
			if (items.Count >= space)
			{
				Debug.Log("Not enough room.");
				return false;
			}

			items.Add(item);    // Add item to list

			// Trigger callback
			if (onItemChangedCallback != null)
				onItemChangedCallback.Invoke();
		}

		return true;
	}

	// Remove an item
	public void Remove(Equipment item)
	{
		items.Remove(item);     // Remove item from list
		// Debug.Log("item removed");
		// Trigger callback
		if (onItemChangedCallback != null)
			onItemChangedCallback.Invoke();
	}

}
