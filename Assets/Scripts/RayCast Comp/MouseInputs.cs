using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseInputs: MonoBehaviour
{
    public GameObject toSpawnIn;

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
        horizontalInput = Input.GetAxis("Mouse X");
        verticalInput = Input.GetAxis("Mouse Y");
        scaleInput = Input.GetAxis("Mouse ScrollWheel");

        /*        horizontalInput = Input.GetAxis("Horizontal");
                verticalInput = Input.GetAxis("Vertical");*/

        findSelected();

        if (selectedObject != null)
        {
            Debug.Log("Selected Game Object: " + selectedObject.name);
            selectedObject.transform.Translate(new Vector3(horizontalInput, verticalInput, 0));
            selectedObject.transform.localScale += new Vector3(scaleInput, scaleInput, scaleInput);
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

                    //GameObject selectedObjectForColor = obj.transform.gameObject;

                    selectedObject = obj.transform.gameObject;
                    Cursor.visible = false;

                    MeshRenderer selectedObjectRendered = selectedObject.GetComponent<MeshRenderer>(); // get renderer
                    selectedObjectRendered.material.color = Color.red;//change material color to red


                    

                }
            }
            else
            {
                MeshRenderer selectedObjectRendered = selectedObject.GetComponent<MeshRenderer>(); // get renderer
                selectedObjectRendered.material.color = Color.white;//change material color to white

                selectedObject = null;
                Cursor.visible = true;
            }


        }

        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(ray, out obj, Mathf.Infinity))
            {
                // selectedObject = obj.transform.gameObject;//not needed
                Destroy(obj.transform.gameObject);


                  
            }
            else
            {
                //Get the ingame position of the cursor

                Vector3 cursorPosition = Input.mousePosition;
                //Make sure to get the correct distance between the prefabe spawn point and
                //Camera position
                cursorPosition.z = Vector3.Distance(new Vector3(0,0,toSpawnIn.transform.position.z)
                                                , new Vector3(0,0,Camera.main.transform.position.z));

                Vector3 inWorldMousePosition = Camera.main.ScreenToWorldPoint(cursorPosition);

                //Spawn in the object at the position of the cursor
                Instantiate(toSpawnIn

                    ,new Vector3(inWorldMousePosition.x
                        , inWorldMousePosition.y
                        , inWorldMousePosition.z)

                    ,Quaternion.identity);

            }

        }

     
    }
}
