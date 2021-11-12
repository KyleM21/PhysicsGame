using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    public Camera cam;
    float absTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        cam.backgroundColor = new Color(0, 0, 0);   
    }

    // Update is called once per frame
    void Update()
    {
        Color color = cam.backgroundColor;
        absTime += Time.deltaTime;
        float val1 = 0.2f * Mathf.Cos(absTime * 0.8f) + 0.125f + 0.2f;
        float val2 = 0.2f * Mathf.Cos(absTime * 0.4f) + 0.125f + 0.2f;
        float val3 = 0.2f * Mathf.Cos(absTime * 0.2f) + 0.125f + 0.2f;
        cam.backgroundColor = new Color((color.r = val1), (color.g = val2), (color.b = val3)); 
    }
}