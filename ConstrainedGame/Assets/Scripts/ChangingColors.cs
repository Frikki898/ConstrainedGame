using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColors : MonoBehaviour {
    // used to change the color value of the pointlight in circles
    private Light pointLight;
    public float r = 255;       // red value
    public float g = 255;       // green value
    public float b = 0;         // blue value
    private float currentTime = 0.0f;       // used to make changes only ever 0.1 seconds
    public float lightFluctateSpeed = 0.1f; // how fast it changes colors
    
    void Start()
    {
        pointLight = GetComponent<Light>();
        pointLight.color = new Color(1, 1, 0);
    }
    void Update()
    {
        
        currentTime = currentTime + Time.deltaTime;
        if (currentTime > lightFluctateSpeed)
        {
            currentTime = 0.0f;
            if (g == 255 && b == 0 && r > 0)
            {
                r -= 5;
                if(r < 0)
                {
                    r = 0;
                }
            }
            else if (r == 0 && g == 255 && b < 255) 
            {
                b += 5;
                if (b > 255)
                {
                    b = 255;
                }
            }
            else if (r == 0 && b == 255 && g > 0)
            {
                g -= 5;
                if (g < 0) {
                    g = 0;
                }
            }
            else if (g == 0 && b == 255 && r < 255)
            {
                r += 5;
                if (r > 255)
                {
                    r = 255;
                }
            }
            else if (r == 255 && g == 0 && b > 0) 
            {
                b -= 5;
                if (b < 0)
                {
                    b = 0;
                }
            }
            else if (r == 255 && b == 0 && g < 255)
            {
                g += 5;
                if (g > 255)
                {
                    g = 255;
                }
            } 
            // since the color values are from 0 to 1 we divide with 255
            pointLight.color = new Color((r/255f), (g/255f), (b/255f));


        }
    }
}
