using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World! from Debug");
        print("Hello World! from Print");
        print("Start runs before an object Updates");
    }

    // Update is called once per frame
    void Update()
    {
        print("This is called once a frame");
    }
}
