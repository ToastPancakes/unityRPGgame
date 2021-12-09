using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Death_Script : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text yourScore;
    Player_Score_Script playerScore;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = FindObjectOfType<Player_Score_Script>().GetComponent<Player_Score_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player_Health_Controller.playerHealth <= 0)
        {
            if (playerScore.playerScore > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore", playerScore.playerScore);
            }
            yourScore.text = "Your Score: " + playerScore.playerScore;
            gameOverPanel.active = true;
            Time.timeScale = 0;
        }
    }
}
