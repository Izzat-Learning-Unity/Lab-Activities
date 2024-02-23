
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SphereScript : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    private float scaleInput;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        changeColor();
        moveSphere();
    }

    void moveSphere()
    {
        horizontalInput = Input.GetAxis("Mouse X");
        verticalInput = Input.GetAxis("Mouse Y");
        scaleInput = Input.GetAxis("Mouse ScrollWheel");

        transform.Translate(new Vector3(horizontalInput, verticalInput, 0));
        transform.localScale += new Vector3(scaleInput, scaleInput, scaleInput);
    }

    void changeColor()
    {

        if (Input.GetMouseButtonDown(0))
        {

            MeshRenderer selectedObjectRendered = GetComponent<MeshRenderer>(); // get renderer
            selectedObjectRendered.material.color = Color.red;//change material color to red
        }


        if (Input.GetMouseButtonDown(1))
        {

            MeshRenderer selectedObjectRendered = GetComponent<MeshRenderer>(); // get renderer
            selectedObjectRendered.material.color = Color.green;//change material color to white
        }



    }
}
