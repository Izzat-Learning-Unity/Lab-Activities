using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSunlightColor : MonoBehaviour
{
    private Light sunLight;
    private Color currentColor = new Color(255f, 255f, 25f);
    // Start is called before the first frame update
    void Start()
    {
        sunLight = GetComponent<Light>();
        //sunLight.type = LightType.Point;
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time % 5 < Time.deltaTime)
        {

            changeColor();
        }

        

    }

    private void changeColor()
    {
        float randomR = Random.Range(0,255);
        currentColor.r = randomR/255;

        float randomG= Random.Range(0, 255);
        currentColor.g = randomG/255;


        float randomB = Random.Range(0, 255);
        currentColor.b = randomB/255;
        
        sunLight.color = currentColor;
    }
}
