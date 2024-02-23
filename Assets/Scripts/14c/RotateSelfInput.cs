using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelfInput : MonoBehaviour
{
    public float rotatationSpeed = 5f;
    private float rotateEarthInput;
    private bool rotating = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetButtonDown("Jump"))
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
            transform.Rotate(0, rotatationSpeed, 0);
        }


    }

}
