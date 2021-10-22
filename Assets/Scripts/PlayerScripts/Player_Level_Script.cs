using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Level_Script : MonoBehaviour
{
    Player_Stat_Script playerStats;
    public static int currentXP;
    public float cooldownTimer = 0;
    public static int xpToLevel = 100;
    public Text levelUpText;
    // Start is called before the first frame update
    void Start()
    {
         playerStats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
        currentXP = playerStats.experiencePoints;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentXP >= xpToLevel)
        {
            playerStats.level += 1;
            currentXP -= xpToLevel;
            xpToLevel = (int)(xpToLevel * 1.5);
            levelUpText.enabled = true;
            cooldownTimer = 3;
            Player_Stat_Controller.strength = Player_Stat_Controller.strength + playerStats.level + 2;
            Player_Stat_Controller.dexterity = Player_Stat_Controller.dexterity + playerStats.level + 2;
            Player_Stat_Controller.endurance = Player_Stat_Controller.endurance + playerStats.level + 2;
            playerStats.health = playerStats.health + playerStats.level + 2;
            playerStats.manaPoints = playerStats.manaPoints + playerStats.level + 2;
            Player_Stat_Controller.magicEndurance = Player_Stat_Controller.magicEndurance + playerStats.level + 2;
            Player_Stat_Controller.intelligence = Player_Stat_Controller.intelligence + playerStats.level + 2;
        }
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            levelUpText.enabled = false;
        }

    }
}
