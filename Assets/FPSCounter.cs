using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FPSCounter : MonoBehaviour
{
    public int FrameRate;
    public Text text;

    // Update is called once per frame
    void Update()
    {
        float current = 0;
        current = Time.frameCount / Time.time;
        FrameRate = (int)current;
        text.text = "FPS: " + FrameRate.ToString(); 
    }
}
