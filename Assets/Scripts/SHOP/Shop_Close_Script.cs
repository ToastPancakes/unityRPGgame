using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Close_Script : MonoBehaviour
{
    public GameObject shopPanel;

    public void CloseShop()
    {
        shopPanel.SetActive(false);
    }

}
