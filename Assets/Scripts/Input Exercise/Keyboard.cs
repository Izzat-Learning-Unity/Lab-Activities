using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    private float rotationSpeed = 5f;
    private float rotationStartTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateCube();
    }

    void rotateCube()
    { 
        //Rotate the cube as long as the arrow keys are pressed
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.Rotate(Vector3.up, rotationSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, -rotationSpeed);
        }

        //Get the time for when the rotation starts
        if (Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.RightArrow))
        {
            rotationStartTime = Time.time;
        }
        //Calculate how long the cube was rotated

        if (Input.GetKeyUp(KeyCode.LeftArrow)|| Input.GetKeyUp(KeyCode.RightArrow))
        {
            float totalRotationTime = Time.time - rotationStartTime;
            Debug.Log("Total Rotation Time: " + totalRotationTime);
        }
    }
}
