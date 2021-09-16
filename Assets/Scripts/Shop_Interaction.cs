using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop_Interaction : MonoBehaviour
{
    public float radius = 0.5f;
    public Transform interactionTransform;
    public Transform player;
    public GameObject shopPanel;
    public float maxDistance = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, interactionTransform.position);
        if (Input.GetButtonDown("Interact"))
        {
            if (distance <= radius)
             {
                shopPanel.SetActive(true);
             }
        }
        /*if (maxDistance <= distance)
        {
            Debug.Log("distance is greater than max distance. distance = " + distance);
            shopPanel.SetActive(false);
        }*/

    }
}
