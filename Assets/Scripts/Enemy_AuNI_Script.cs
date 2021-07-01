using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AuNI_Script : MonoBehaviour
{
    public int randomAction;
    public int enemySpeed;
    public float actionTimer;
    public float noActionTimer;

    // Start is called before the first frame update
    void Start()
    {
        randomAction = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        actionTimer -= Time.deltaTime;
        noActionTimer -= Time.deltaTime;
        if (actionTimer == 0)
        {
            randomAction = 0;
            noActionTimer = 2f;
        }
        if (noActionTimer == 0)
        {
            randomAction = Random.Range(1, 5);
        }

        if (randomAction == 1)
        {
            transform.position += transform.up * enemySpeed * Time.deltaTime;
            if(actionTimer <= 0)
            {
                actionTimer = 3f;
            }
            
        }
        if (randomAction == 2)
        {
            transform.position -= transform.up * enemySpeed * Time.deltaTime;
            if (actionTimer <= 0)
            {
                actionTimer = 3f;
            }
        }
        if (randomAction == 3)
        {
            transform.position += transform.right * enemySpeed * Time.deltaTime;
            if (actionTimer <= 0)
            {
                actionTimer = 3f;
            };
        }
        if (randomAction == 4)
        {
            transform.position -= transform.right * enemySpeed * Time.deltaTime;
            if (actionTimer <= 0)
            {
                actionTimer = 3f;
            }
        }
        if (randomAction == 5)
        {
            if (actionTimer <= 0)
            {
                actionTimer = 3f;
            }

        }


       
    }
}
