using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Health_Bar : MonoBehaviour
{
    public float enemyHealthAmount;
    public Image enemyHealthBar;
    public Enemy_Creator_Script enemyStats;
    // Start is called before the first frame update
    private void Start()
    {
        enemyHealthAmount = 1f / enemyStats.health;
    }

    // Update is called once per frame
    void Update()
    {
        enemyHealthBar.fillAmount = enemyHealthAmount * enemyStats.health;
    }
}
