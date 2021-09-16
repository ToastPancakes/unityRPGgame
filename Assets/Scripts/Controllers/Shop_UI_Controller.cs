using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop_UI_Controller : MonoBehaviour
{
    public Text shopMoneyText;

    // Update is called once per frame
    void Update()
    {
        shopMoneyText.text = "Gold: " + Player_Gold_Controller.playergold;
    }
}
