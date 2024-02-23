using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private GameObject selectedObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Mouse X");
        verticalInput = Input.GetAxis("Mouse Y");

        selectAndDeselectObject();

        if (selectedObject != null)
        {
            Debug.Log("Selected Game Object: " + selectedObject.name);
            selectedObject.transform.Translate(new Vector3(horizontalInput, verticalInput, 0));
        }
    }

    void selectAndDeselectObject()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit obj;


        if (Input.GetMouseButtonDown(0))
        {

            //Select the object
            if (selectedObject == null)
            {
                if (Physics.Raycast(ray, out obj, Mathf.Infinity))
                {
                    selectedObject = obj.transform.gameObject;
                    Cursor.visible = false;

                }
            }
            else //Deselect object
            {
                selectedObject = null;
                Cursor.visible = true;
            }
        }


    }
}
