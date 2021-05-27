using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float playerSpeed = 0.0001f;
    Animator animationPlayer;
    // Start is called before the first frame update
    void Start()
    {
        animationPlayer = gameObject.GetComponent<Animator>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if(!Player_Melee_Attack.isAttacking)
        {
            if (Input.GetKey(KeyCode.W))
            {
                animationPlayer.enabled = true;
                animationPlayer.SetInteger("walkState", 1);
                transform.position += transform.up * playerSpeed * Time.deltaTime;
            }

            else if (Input.GetKey(KeyCode.A))
            {
                animationPlayer.enabled = true;
                animationPlayer.SetInteger("walkState", 4);
                transform.position += -transform.right * playerSpeed * Time.deltaTime;
            }

            else if (Input.GetKey(KeyCode.S))
            {
                animationPlayer.enabled = true;
                animationPlayer.SetInteger("walkState", 3);
                transform.position += -transform.up * playerSpeed * Time.deltaTime;
            }

            else if (Input.GetKey(KeyCode.D))
            {
                animationPlayer.enabled = true;
                animationPlayer.SetInteger("walkState", 2);
                transform.position += transform.right * playerSpeed * Time.deltaTime;
            }
            else
            {
                animationPlayer.enabled = false;
            }
        }
       
    }

}
          
