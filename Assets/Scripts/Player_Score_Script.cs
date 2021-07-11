using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Score_Script : MonoBehaviour
{
    public int playerScore = 0;
    public Text inGameScore;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        inGameScore.text = "Score: " + playerScore;
    }
}
