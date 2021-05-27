using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_UI_Controller : MonoBehaviour
{

    Player_Stat_Script playerMaxHealth = new Player_Stat_Script();

    public void levelOne()
    {
        Time.timeScale = 1;
        Player_Health_Controller.playerHealth = 100;
        SceneManager.LoadScene("Level_One");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }


}
