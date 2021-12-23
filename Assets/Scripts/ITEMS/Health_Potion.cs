using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Health Potion", menuName = "Inventory/Health Potion")]
public class Health_Potion : Item
{
    public int healAmount;
    public GameObject player;
    Player_Stat_Script playerStats;
    public int cost = 100;

    void Start()
    {
        Debug.Log("start is being called");
    }
    public override void Use()
    {
        playerStats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
        healAmount = playerStats.health / 5;
        base.Use();
        Player_Health_Controller.playerHealth += healAmount;
        RemoveFromInventory();
        if (Player_Health_Controller.playerHealth > playerStats.health)
        {
            Player_Health_Controller.playerHealth = playerStats.health;
        }
    }
}
