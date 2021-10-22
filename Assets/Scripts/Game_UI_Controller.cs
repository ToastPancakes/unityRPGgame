using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_UI_Controller : MonoBehaviour
{
    Player_Stat_Script playerStats;
    private float healthAmount;
    public Image healthBar;
    public Image manaBar;
    public float manaAmount;
    public Text currentLevel;
    public Image xpBar;
    public Text goldInt;
    public Text healthText;
    public Text manaText;
    public Text xpText;

    void Start()
    {
        playerStats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
        healthAmount = 1f / playerStats.health;
        manaAmount = 1f / playerStats.manaPoints;
    }

    // Update is called once per frame
    void Update()
    {
        goldInt.text = Player_Gold_Controller.playergold.ToString();
        healthBar.fillAmount = healthAmount * Player_Health_Controller.playerHealth;
        manaBar.fillAmount = (float) manaAmount * Player_Mana_Controller.playerMana;
        currentLevel.text = "Level " + playerStats.level;
        xpBar.fillAmount = (float) Player_Level_Script.currentXP / Player_Level_Script.xpToLevel;
        healthText.text = Player_Health_Controller.playerHealth + "/" + playerStats.health;
        manaText.text = Player_Mana_Controller.playerMana + "/" + playerStats.manaPoints;
        xpText.text = Player_Level_Script.currentXP + "/" + Player_Level_Script.xpToLevel;
        // Debug.Log("xpBar fill amount = " + xpBar.fillAmount + " current xp = " + Player_Level_Script.currentXP + " xp to level = " + Player_Level_Script.xpToLevel); 
    }
}
