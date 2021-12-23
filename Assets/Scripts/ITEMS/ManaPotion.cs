using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Mana Potion", menuName = "Inventory/Mana Potion")]
public class ManaPotion : Item
{
    public int manaGainAmount;
    public GameObject player;
    Player_Stat_Script playerStats;
    public int cost = 50;


    public override void Use()
    {
        playerStats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
        manaGainAmount = playerStats.manaPoints / 5;
        base.Use();
        Player_Mana_Controller.playerMana += manaGainAmount;
        RemoveFromInventory();
        if (Player_Mana_Controller.playerMana > playerStats.manaPoints)
        {
            Player_Mana_Controller.playerMana = playerStats.manaPoints;
        }
    }
}
