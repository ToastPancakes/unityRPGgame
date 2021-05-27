using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Projectile_Damage : MonoBehaviour
{
    public Enemy_Creator_Script enemyStats;
    int critNum = 0;
    public int damage = 1;
    public static int playerDamage = 1;
    private void Start()
    {
        //enemyStats = FindObjectOfType<Enemy_Creator_Script>().GetComponent<Enemy_Creator_Script>();
        critNum = Random.Range(1, 100);
    }

    public void Init(Enemy_Creator_Script enemyStats)
    {
        this.enemyStats = enemyStats;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.CompareTag("Player"))
        {
            critNum = Random.Range(1, 100);
            damage = enemyStats.dexterity;

            Debug.Log("damage = " + damage);
            Debug.Log("enemy stats dex = " + enemyStats.dexterity);
            if (critNum <= 10)
            {
                damage *= 2;
            }

            Player_Health_Controller.playerHealth -= damage;

            Destroy(this.gameObject);
        }
    }

}

