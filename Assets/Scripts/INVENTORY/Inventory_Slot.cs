using UnityEngine;
using UnityEngine.UI;

public class Inventory_Slot : MonoBehaviour
{
    Item item;
    public Image icon;
    public Button removeButton;
    public void AddItem(Item newItem)
    {
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
        Inventory.instance.Remove(item);
        Debug.Log("OnRemoveButton is being called");
    }
    

    public void useItem()
    {
        if(item != null)
        {
            item.Use();
        }
    }
}
