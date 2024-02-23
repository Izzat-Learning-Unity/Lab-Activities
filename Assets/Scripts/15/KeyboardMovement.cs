using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class KeyboardMovement : MonoBehaviour
{
    public float speed = 10f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { // There is a much more efficent way to do with this with the Input Manger (getAxis("Horizontal) and getAxis("Vertical)


        MoveCube();

    }

    void MoveCube()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }


        /*        horizontalInput = Input.GetAxis("Mouse X");
                verticalInput = Input.GetAxis("Mouse Y");


                transform.Translate(speed * Time.deltaTime* horizontalInput, speed * Time.deltaTime * verticalInput, 0);*/

    }
}
