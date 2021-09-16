using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop_Buy_Script : MonoBehaviour
{
    public int itemCost = 100;
    public Item buyableitem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuyItem()
    {
        if (Player_Gold_Controller.playergold >= itemCost)
        {
            
            if (Inventory.instance.Add(buyableitem))
            {
                Player_Gold_Controller.playergold -= itemCost;
            }
           
        }
    }
}
