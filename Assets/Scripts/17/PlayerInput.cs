using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float scaleInput;
    private GameObject selectedObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the cube should be moved by mouse movements
        horizontalInput = Input.GetAxis("Mouse X");
        verticalInput = Input.GetAxis("Mouse Y");
        scaleInput = Input.GetAxis("Mouse ScrollWheel");

        /*        horizontalInput = Input.GetAxis("Horizontal");//If the cube should be moved by keyboard inputs
                verticalInput = Input.GetAxis("Vertical");*/

        Debug.Log("Mouse X: "+horizontalInput+", Mouse Y: "+verticalInput);

        findSelected();

        if (selectedObject != null)
        {
            Debug.Log("Selected Game Object: " + selectedObject.name);
            selectedObject.transform.Translate(new Vector3(horizontalInput, verticalInput, 0));
           
        }
    
    }


    void findSelected()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit obj;


        if (Input.GetMouseButtonDown(0))// if removed it will select every object
        {


            if (selectedObject == null)
            {
                if (Physics.Raycast(ray, out obj, Mathf.Infinity))
                {
                    selectedObject = obj.transform.gameObject;
                    Cursor.visible = false;

                }
            }
            else
            {
                selectedObject = null;
                Cursor.visible = true;
            }


        }

    

     
    }
}
