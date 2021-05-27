using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform target;
    public Vector3 cameraPosition;
    public float clampx, clampy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            cameraPosition = new Vector3(target.position.x, target.position.y, -10f);
            transform.position = cameraPosition;
        }
    }
}
