using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Collision : MonoBehaviour
{
    public Enemy_Creator_Script enemyStats;
    public Player_Stat_Script playerStats;
    int critNum = 0;
    int damage = 1;
    int dropNum = 20;
    public GameObject heart;
    public static int playerDamage = 1;
    private void Start()
    {
        enemyStats = GetComponent<Enemy_Creator_Script>();
        playerStats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
        critNum = Random.Range(1, 100);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.CompareTag("Player"))
        {
            damage = enemyStats.strength;

            if (critNum <= 5)
            {
                damage *= 2;
            }

            Player_Health_Controller.playerHealth -= damage;
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            playerDamage = playerStats.intelligence;


            
            damageEnemy(5);
            Destroy(collision.gameObject);
        }

    }


    public void damageEnemy(int critNum)
    {
        if (Random.Range(1,100) <= critNum)
        {
            playerDamage *= 2;
        }

        enemyStats.health -= playerDamage;
        Debug.Log("Enemy Health = " + enemyStats.health);

        if (enemyStats.health <= 0)
        {
            dropNum = Random.Range(1, 101);
            if(dropNum <= 50)
            {
               
                Instantiate(heart, transform.position, Quaternion.identity );
            }
            Player_Level_Script.currentXP += enemyStats.experiencePoints;
            Destroy(this.gameObject);
        }
    }

 
}
