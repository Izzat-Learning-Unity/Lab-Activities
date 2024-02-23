using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) {

            transform.position = new Vector3(0, 3, 0);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        counter++;
        Debug.Log("The Cube Collided With: "+collision.gameObject.name+" "+ counter+" times");
    }
}
