using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Heal_Script : MonoBehaviour
{
    public int healAmount;
    public GameObject player;
    Player_Stat_Script playerStats;
    

    private void Start()
    {
        playerStats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
        healAmount = playerStats.health / 5;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Player_Health_Controller.playerHealth <= playerStats.health)
            {
                Player_Health_Controller.playerHealth += healAmount;
                if (Player_Health_Controller.playerHealth > playerStats.health)
                {
                    Player_Health_Controller.playerHealth = playerStats.health;
                }
                Destroy(this.gameObject);
            }
            
        }
       
    }

}
