using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Patrol : MonoBehaviour
{
    public int enemySpeed = 5;
    public Transform patrolPointA;
    public Transform patrolPointB;
    public int patrolPointPosition = 0;
    public Transform[] patrolPoints;
    public GameObject playerTransform;
    public float enemyLineOfSight = 2;
    // Start is called before the first frame update
    void Start()
    {
        patrolPoints = new Transform[2];
        //Debug.Log("array size = " + patrolPoints.Length);
        patrolPoints[0] = patrolPointA;
        patrolPoints[1] = patrolPointB;
        //Debug.Log("array position 0 = " + patrolPoints[0]);
    }


    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, patrolPoints[patrolPointPosition].position) < 0.01f) 
        {
            patrolPointPosition++;
            if(patrolPointPosition >= patrolPoints.Length)
            {
                patrolPointPosition = 0;
            }
        }
       // Debug.Log("distance = " + Vector2.Distance(playerTransform.transform.position, transform.position));
        if (Vector2.Distance(playerTransform.transform.position, transform.position) < enemyLineOfSight)
        {
            
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[patrolPointPosition].position, enemySpeed * Time.deltaTime);
        }


    }
}
