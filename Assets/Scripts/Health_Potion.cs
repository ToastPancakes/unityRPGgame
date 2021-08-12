using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Health Potion", menuName = "Inventory/Health Potion")]
public class Health_Potion : Item
{
    public int healAmount;
    public GameObject player;
    Player_Stat_Script playerStats;


    private void Start()
    {
        Debug.Log("start is being called");
        playerStats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
        healAmount = playerStats.health / 4;
    }
    public override void Use()
    {
        base.Use();
        Player_Health_Controller.playerHealth += healAmount;
        RemoveFromInventory();
    }
}
