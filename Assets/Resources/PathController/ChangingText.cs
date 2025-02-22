﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ChangingText : MonoBehaviour
{

    public Text mytext = null;
    private string currentPathName;
    public MoveBetweenPoints tracker; 
    
     // Start is called before the first frame update
    void Start()
    {
        //tracker= gameObject.A
        //mytext = this.getWelcomeText();
        //currentPathName = tracker.GetCurrentPath().pathName;


    }

    private void Update()
    {
        currentPathName = tracker.GetCurrentPath().pathName;
        this.ChangeOutputText(); 


    }

    public Text ChangeOutputText()
    {
        switch (currentPathName)
        {
            case "prepreOrbit":
                mytext.text= "Hello from the Chandra X-Ray Observatory. Click anywhere on the screen to orbit the spacecraft and see it from all angles.  Clicking will move you along to another stop on the tour. ";
                return mytext; 
             
            case "preOrbit":
                mytext.text= "Intro_ClickText";
                return mytext; 

            case "tour6":
                mytext.text= "Chandra is almost 14m long, about the size of a school bus.  It is only centimeters smaller than the largest payload the space shuttle could carry.";
                return mytext;

            case "tour1a":
                mytext.text = "X-rays are too energetic to bounce off traditional mirrors like we use to see our reflection.";
                return mytext;

            case "tour1b":
                mytext.text = "Instead, Chandra has nested\\n barrel-shaped mirrors that\\n allow the X-rays to skip\\n like a pebble across a pond\\n and then focus on the detector\\n 10 meters away.";
                return mytext;

            case "tour2":
                mytext.text = "Chandra uses cameras and \\nspectrometers at its target\\n to analyze the X-rays\\n coming from deep space.";
                return mytext;

            case "tour3a":
                mytext.text = "Chandra's solar panels collect power for the telescope's detectors and its radio communication with the Earth.";
                return mytext;

            case "tour3b":
                mytext.text = "The electricity is also used to heat the mirrors to keep them from deforming in the cold temperatures of space.";
                return mytext;

            case "tour4":
                mytext.text = "In order to provide motion to the observatory, Chandra has two different sets of thrusters. Chandra aims with high-precision gyroscopes.";
                return mytext;

            case "tour5a":
                mytext.text = "The antennas on Chandra are its link to NASA's Deep Space Network, a series of three radio dishes located at different parts of Earth.";
                return mytext;

            case "tour5b":
                mytext.text = "Once on Earth, the system delivers the data to the Chandra X-ray Center, in Cambridge, Massachusetts.";
                return mytext;

            case "tour7":
                mytext.text = "...";
                return mytext;


            default:
                mytext.text= "Welcome to the Chandra X-Ray Observatory";
                return mytext; 

        }
    }


    //public Text getText()
    //{
    //    return mytext; 
    //}


    //Text getWelcomeText()
    //{
    //    mytext.text = "Welcome to the Chandra Experience"; 
    //    return mytext; 
    //}


}
