using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            Vector2 touchPosition = Input.GetTouch(0).position;
            double halfScreen = Screen.width / 2;

            if(touchPosition.x < halfScreen)//Left side of screen
            {
                transform.Translate(Vector3.left * 5 * Time.deltaTime);
            }else if (touchPosition.x >= halfScreen)
            {
                transform.Translate(Vector3.right * 5 * Time.deltaTime);
            }
        }
    }
}
