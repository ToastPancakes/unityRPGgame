using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Warp_Script : MonoBehaviour
{
    public Transform warpPoint;
    public Transform player;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.position = warpPoint.position;
    }
}
