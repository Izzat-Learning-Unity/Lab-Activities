using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PinScript : MonoBehaviour
{
    private Vector3 originalPos;
    private Quaternion originalRotation;
    private bool knockedOver = false;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
        originalRotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        keepScore();
        resetPins();


    }

    void keepScore()
    {
        if (!knockedOver) // prevent counting the score as long as the pin is knocked over
        {
            if (transform.localEulerAngles.z > 10 //detect if the pin is leaning
            || transform.localEulerAngles.x > 10
            || transform.localEulerAngles.y > 10)
            {
                knockedOver = true;
                Launch.Score += 1;

            }
        }
    }


    void resetPins()
    {
        if (Input.GetKey(KeyCode.G)) //reset pins
        {
            Launch.Score = 0;
            transform.position = originalPos;
            transform.rotation = originalRotation;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            knockedOver = false;
        }
    }

}
