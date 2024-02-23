using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundInput : MonoBehaviour
{
    public GameObject sun;
    public float rotationSpeed=1f;
    public float sunRotationSpeed = 1f;
    private bool rotating=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!rotating)
            {
                rotating = true;

            }
            else
            {
                rotating = false;
            }
        }

        if (rotating)
        {
            sun.transform.Rotate(0, sunRotationSpeed, 0);
            transform.RotateAround(sun.transform.position, Vector3.up, -1*rotationSpeed);
        }



      
        
    }
}
