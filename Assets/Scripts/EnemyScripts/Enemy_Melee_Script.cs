using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Melee_Script : MonoBehaviour
{
    public GameObject player;
    public float chaseRange = 6;
    public int enemySpeed = 5;
    public float attackingRange = 0.5f;
    public static bool isAttacking = false;
    public Transform attackLocation;
    public LayerMask playerLayer;
    public GameObject meleeAttack;
    Enemy_Creator_Script enemyStats;
    public float meleeCooldown = 0f;
    public float cooldown = 0f;
    public int damage;
    public int critnum;
    // Start is called before the first frame update
    void Start()
    {
        enemyStats = FindObjectOfType<Enemy_Creator_Script>().GetComponent<Enemy_Creator_Script>();
        damage = enemyStats.strength;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, transform.position) < chaseRange)
        {
            transform.position = Vector2.MoveTowards(transform.position,player.transform.position, enemySpeed * Time.deltaTime);
            
            if ((Vector2.Distance(player.transform.position, transform.position) < attackingRange))
            {
                critnum = Random.Range(1, 101);
                if (meleeCooldown <= 0)
                {
                    Enemy_Collision.playerDamage = enemyStats.strength;
                    Collider2D[] playersCollided = Physics2D.OverlapCircleAll(attackLocation.position, attackingRange, playerLayer);
                    meleeCooldown = cooldown;
                    isAttacking = true;
                    for (int i = 0; i < playersCollided.Length; i++)
                    {
                        if (critnum < 11)
                        {
                            damage *= 2;
                        }
                       Player_Health_Controller.playerHealth -= damage;
                    }
                    

                }


            }
            else if (meleeCooldown <= 0f)
            {
                meleeAttack.active = false;
                isAttacking = false;
            }
            meleeCooldown -= Time.deltaTime;
        }
    }
    
}
