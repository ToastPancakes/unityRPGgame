using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 0.1f;
    public Transform interactionTransform;
    public Transform player;
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
        if (Input.GetButtonDown("Interact"))
        {
            if (!hasInteracted)
            {
                // If we are close enough
                float distance = Vector3.Distance(player.position, interactionTransform.position);
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
