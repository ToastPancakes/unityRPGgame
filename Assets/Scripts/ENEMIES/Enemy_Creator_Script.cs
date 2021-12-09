using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Creator_Script : MonoBehaviour
{
    Enemy_Creator_Script thisEnemy;
    Enemy_Stat_Script enemyStats;
    public int strength = 0;
    public int endurance = 0;
    public int dexterity = 0;
    public int intelligence = 0;
    public int magicEndurance = 0;
    public int experiencePoints = 0;
    public int health = 0;
    public int manaPoints = 0;
    public int level = 0;
    public int gold = 0;

    public int playerLevelCounter = 1;
    Player_Stat_Script playerStats;
    void Start()
    {
        playerStats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
    }
    public void EnemyStatIncrease()
    {
        strength = (int)(strength * 1.75f);
        endurance = (int)(endurance * 1.75f);
        dexterity = (int)(dexterity * 1.75f);
        intelligence = (int)(intelligence * 1.75f);
        magicEndurance = (int)(magicEndurance * 1.75f);
        experiencePoints = (int)(experiencePoints * 1.5f);
        health = (int)(health * 1.25f);
        manaPoints = (int)(manaPoints * 1.75f);
        level = level + 1;
        gold = (int)(gold * 1.2f);
    }

    private void Update()
    {
        if(playerLevelCounter != playerStats.level)
        {
            playerLevelCounter = playerStats.level;
            EnemyStatIncrease();
        }
        
    }
}



