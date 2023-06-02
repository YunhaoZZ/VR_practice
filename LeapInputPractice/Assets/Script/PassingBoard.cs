using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;
using TMPro;
using System;

public class PassingBoard : MonoBehaviour
{

    //public Canvas resultCanvas;
    public LeapProvider leapProvider;
    public TMP_Text Count;
   

    private void OnEnable()
    {
        leapProvider.OnUpdateFrame += OnUpdateFrame;
    }
    private void OnDisable()
    {
        leapProvider.OnUpdateFrame -= OnUpdateFrame;
    }

    void OnUpdateFrame(Frame frame)
    {
        //Get a list of all the hands in the frame and loop through
        //to find the first hand that matches the Chirality
        /*
        foreach (var hand in frame.Hands)
        {
            if (hand.IsLeft)
            {
                //We found a left hand
            }
        }
        */


        //Use a helpul utility function to get the first hand that matches the Chirality
        Hand _leftHand = frame.GetHand(Chirality.Left);
        Hand _rightHand = frame.GetHand(Chirality.Right);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Cylinder")
        {
            int number = 0;
            Int32.TryParse(Count.text.Substring(16) , out number);
            string updatedNumber = "Number of Pass: " + ++number;
            Count.text = updatedNumber;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
