using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Melee_Script : MonoBehaviour
{
    public GameObject player;
    public float chaseRange = 6;
    public int enemySpeed = 5;
    public float attackingRange = 0.5f;
    public Transform attackLocation;
    public LayerMask playerLayer;
    public GameObject meleeAttack;
    Enemy_Creator_Script enemyStats;
    public float meleeCooldown = 0f;
    public float cooldown = 0f;
    public int damage = 0;
    public int critnum;
    // Start is called before the first frame update
    void Start()
    {
        enemyStats = GetComponent<Enemy_Creator_Script>();
        damage = enemyStats.strength;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, transform.position) < chaseRange)
        {
            
            transform.position = Vector2.MoveTowards(transform.position,player.transform.position, enemySpeed * Time.deltaTime);
          
        }

        if ((Vector2.Distance(player.transform.position, transform.position) < attackingRange))
        {
            damage = (int)enemyStats.strength - Player_Stat_Controller.endurance; 
            if(damage < 0)
            {
                damage = 0;
            }
            critnum = Random.Range(1, 101);
            if (meleeCooldown <= 0)
            {
                Collider2D[] playersCollided = Physics2D.OverlapCircleAll(attackLocation.position, attackingRange, playerLayer);
                meleeCooldown = cooldown;
                for (int i = 0; i < playersCollided.Length; i++)
                {
                    Debug.Log("cooldown = " + meleeCooldown);
                    if (critnum < 11)
                    {

                    damage *= 2;
                    }
                    Player_Health_Controller.playerHealth -= damage;
                }   
            }
        }

        meleeCooldown -= Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            chaseRange = Vector2.Distance(player.transform.position, transform.position) + 3;
            Debug.Log("chaseRange = " + chaseRange);
        }
    }
}
