using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Melee_Attack : MonoBehaviour
{
    public GameObject meleeAttack;
    public float meleeCooldown = 0f;
    public static bool isAttacking = false;
    public Transform attackLocation;
    public float attackRange = 0f;
    public LayerMask enemies;
    public Animation swordSwing;
    public Animator Animator;
    Player_Stat_Script Player_Stats;
    // Start is called before the first frame update
    void Start()
    {
        Player_Stats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (meleeCooldown <= 0f)
            {
                Animator.Play("swordSwing");
                Enemy_Collision.playerDamage = Player_Stats.strength;
                Collider2D[] damage = Physics2D.OverlapCircleAll(attackLocation.position, attackRange, enemies);
                meleeCooldown = 0.3f;
                meleeAttack.active = true;
                isAttacking = true;
                for(int i = 0; i < damage.Length; i++)
                {
                    damage[i].gameObject.GetComponent<Enemy_Collision>().damageEnemy(10);

                }


            }

          
        }
        else if(meleeCooldown <= 0f)
        {
            meleeAttack.active = false;
            isAttacking = false;
        }
        meleeCooldown -= Time.deltaTime;
    }
}
