using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCubes : MonoBehaviour
{
    private Vector3 originalPos;
    private Quaternion originalRotation;
    // Start is called before the first frame update
    void Start()
    {
        originalPos= transform.position;
        originalRotation =  transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity= Vector3.zero;
            
            transform.position = originalPos;
            transform.rotation = originalRotation;
        }
    }
}
