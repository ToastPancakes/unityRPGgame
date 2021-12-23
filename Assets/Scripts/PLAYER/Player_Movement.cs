using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float playerSpeed = 0.000001f;
    Animator animationPlayer;
    public GameObject sword;
    public float horizontalAxis;
    public float verticalAxis;

    // Start is called before the first frame update
    void Start()
    {
        animationPlayer = gameObject.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");

        transform.Translate(transform.right * horizontalAxis * Time.deltaTime * playerSpeed);
        transform.Translate(transform.up * verticalAxis * Time.deltaTime * playerSpeed);
    }

}


          
