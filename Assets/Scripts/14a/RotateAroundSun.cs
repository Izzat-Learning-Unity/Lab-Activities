using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSun : MonoBehaviour
{
    public GameObject sun;
    public float rotationSpeed=1f;
    public float sunRotationSpeed=1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sun.transform.Rotate(0, sunRotationSpeed, 0);

        transform.RotateAround(sun.transform.position,Vector3.up,rotationSpeed);
        
    }
}
