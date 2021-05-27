using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Chase_Player : MonoBehaviour
{
    public Transform player;
    public int chaseRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.position, transform.position) < chaseRange && this.GetComponent<AIPath>().canMove == false) 
        {
            this.GetComponent<AIPath>().canMove = true;
        }
        if (Vector2.Distance(player.position, transform.position) > chaseRange)
        {
            this.GetComponent<AIPath>().canMove = false;
        }

    }
}
