using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleManager : MonoBehaviour
{
    private int xValue=0;

    private int yValue=0;
    
    public Transform circleTransform; 
    // Start is called before the first frame update
    void Start()
    {
        //this is xValue-2 because I wanted the values to be centred on the screen 
        circleTransform.localPosition = new Vector3(xValue-2, yValue-2, -1);
    }

    public void updateXValue(string newXValue)
    {
        Debug.Log(newXValue);
        int newXInt = Mathf.Clamp(Convert.ToInt16(newXValue),0,4);
        if (newXInt < 0)
        {
            xValue = 0;
        }
        else 
        {
            xValue = newXInt;
        }
        circleTransform.localPosition = new Vector3(xValue-2, yValue-2, -1);
    }

    public void updateYValue(string newYValue)
    {
        int newYInt = Mathf.Clamp(Convert.ToInt16(newYValue),0,4);
        if (newYInt < 0)
        {
            yValue = 0;
        }
        else
        {
            yValue = newYInt;
        }
        
        circleTransform.localPosition = new Vector3(xValue-2, yValue-2, -1);
    }

    // Update is called once per frame
    void Update()
    {


    }
}
