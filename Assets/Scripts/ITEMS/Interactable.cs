using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 0.5f;
    public Transform interactionTransform;
    public Transform player;
    public GameObject playerTransform;
    public bool hasInteracted = false;

    public virtual void Interact()
    {

    }
    void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform;

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("found player: " + playerTransform);
        if (Input.GetButtonDown("Interact"))
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player");
            if (!hasInteracted)
            {
                // If we are close enough
                float distance = Vector3.Distance(playerTransform.transform.position, interactionTransform.position);
                if (distance <= radius)
                {
                    // Interact with the object
                    Interact();
                    hasInteracted = true;
                }

            }
        }
    }


}
