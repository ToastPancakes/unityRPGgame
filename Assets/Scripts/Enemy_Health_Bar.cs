using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Health_Bar : MonoBehaviour
{
    public float enemyHealthAmount = 1f / 50f;
    public Image enemyHealthBar;
    public Enemy_Creator_Script enemyStats;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        enemyHealthBar.fillAmount = enemyHealthAmount * enemyStats.health;
    }
}
