using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Heal_Script : MonoBehaviour
{
    public int healAmount = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Player_Health_Controller.playerHealth += healAmount;
        Destroy(this.gameObject);
    }

}
