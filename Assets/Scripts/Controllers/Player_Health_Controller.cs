using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health_Controller : MonoBehaviour
{
    public static int playerHealth = 0;
    Player_Stat_Script playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
        playerHealth = playerStats.health;
        Debug.Log("Awake, " + playerHealth);
    }

}
