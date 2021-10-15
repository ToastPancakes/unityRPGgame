using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Stat_Controller : MonoBehaviour
{
    Player_Stat_Script playerStats;
    public static int endurance;
    //
    public static int strength;
    //
    public static int dexterity;
    //
    public static int intelligence;
    //
    public static int magicEndurance;
    void Start()
    {
        
        playerStats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
        endurance = playerStats.endurance;
        strength = playerStats.strength;
        dexterity = playerStats.dexterity;
        intelligence = playerStats.intelligence;
        magicEndurance = playerStats.magicEndurance;
        Debug.Log(strength);
    }

}
