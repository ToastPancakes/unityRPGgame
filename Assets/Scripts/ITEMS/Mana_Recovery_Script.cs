using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana_Recovery_Script : MonoBehaviour
{
    public int manaGainAmount;
    public GameObject player;
    Player_Stat_Script playerStats;
    

    private void Start()
    {
        playerStats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
        manaGainAmount = playerStats.manaPoints / 5;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(Player_Mana_Controller.playerMana <= playerStats.manaPoints)
            {
                Player_Mana_Controller.playerMana += manaGainAmount;
            }
            if (Player_Mana_Controller.playerMana > playerStats.manaPoints)
            {
                Player_Mana_Controller.playerMana = playerStats.manaPoints;
            }
            Destroy(this.gameObject);
        }

    }
}
