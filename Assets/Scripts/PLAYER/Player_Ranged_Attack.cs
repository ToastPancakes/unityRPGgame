using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ranged_Attack : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public GameObject bulletPrefab;
    private Vector3 target;
    public float cooldownTimer = 0f;
    public float manaRegenTime = 0f;
    Player_Stat_Script Player_Stats;
    public AudioClip sound;
    public AudioSource source;
    public int abilityCost = 5;
    // Start is called before the first frame update
    void Start()
    {
        Player_Stats = FindObjectOfType<Player_Stat_Script>().GetComponent<Player_Stat_Script>();
    }
     public void PlaySound(string soundToLoad)
     {
         sound = Resources.Load<AudioClip>(soundToLoad);
         source.PlayOneShot(sound);
     } 
     
    
    void Update()
    {
        target = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 difference = target - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        difference.Normalize();

        if (Input.GetKey(KeyCode.Space) && cooldownTimer <= 0 && Player_Mana_Controller.playerMana >= abilityCost) 
        {

            fireBullet(difference, rotationZ);
            cooldownTimer = 0.5f;
            manaRegenTime = 5f;
            Player_Mana_Controller.playerMana -= abilityCost;
            PlaySound("magicAttack");
        }

        manaRegeneration();
        cooldownTimer -= Time.deltaTime;
        manaRegenTime -= Time.deltaTime;
    }



    void fireBullet(Vector3 direction, float rotationZ)
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = transform.position;
        b.transform.right = direction;
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        Destroy(b.gameObject, 2);
    }

    void manaRegeneration()
    {
        /// If mana is not full
        if(Player_Mana_Controller.playerMana < Player_Stats.manaPoints && manaRegenTime <= 0)
        {
            Player_Mana_Controller.playerMana += 15;
            manaRegenTime = 5f;
            if (Player_Mana_Controller.playerMana > Player_Stats.manaPoints)
            {
                Player_Mana_Controller.playerMana = Player_Stats.manaPoints;
            }
        }
    }
}