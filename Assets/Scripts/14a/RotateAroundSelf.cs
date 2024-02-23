using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSelf : MonoBehaviour
{
    public float rotatationSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotatationSpeed, 0);
    }
}
