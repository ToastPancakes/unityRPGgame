using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ranged_Attack : MonoBehaviour
{
    [SerializeField] private Enemy_Creator_Script enemyStats;

    public float bulletSpeed = 10f;
    public GameObject bulletPrefab;
    private Vector3 target;
    public float cooldownTimer = 0f;
    public GameObject player;
    public float enemyLineOfSight = 7;
    ///public AudioClip sound;
    ///public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    /* public void PlaySound(string soundToLoad)
     {
         sound = Resources.Load<AudioClip>(soundToLoad);
         source.PlayOneShot(sound);
     } */


    void Update()
    {
        target = player.transform.position;

        Vector3 difference = target - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        difference.Normalize();

        if (Vector2.Distance(player.transform.position, transform.position) < enemyLineOfSight && cooldownTimer <= 0)
        {

            fireBullet(difference, rotationZ);
            cooldownTimer = 1f;
           
        }


        cooldownTimer -= Time.deltaTime;
       
    }



    void fireBullet(Vector3 direction, float rotationZ)
    {
        GameObject b = Instantiate(bulletPrefab);
        b.GetComponent<Enemy_Projectile_Damage>().Init(enemyStats);
        b.transform.position = transform.position;
        b.transform.right = direction;
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        Destroy(b.gameObject, 2);
    }

}
