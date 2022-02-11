// library:
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// script name and script type:
public class Test : MonoBehaviour
{
    //variables up top
    /*
        multiline comment
    */

    public int fuel = 100;
    public int laps;
    public float lapProgress;
    public float reqLapProgress = 200f;


    // Start is called before the first frame update
    // start function
    void Start()
    {
        
    }

    // Update is called once per frame
    // happens every single frame:
    void Update()
    {
        
        //check how much fuel car has
        //if still more then 0 fuel, lets go!
        if (fuel > 0)
        {
            //we have fuel
            //increase progress and decrease fuel
            lapProgress += 5; //increase by 5
            fuel--; //decrease by one
        }
        else
        {
            //we dont have fuel
            Debug.Log("We've run out of fuel! YOU A FOOL!");
        }
        
        //is our current progress = or > the requried progress
        if (lapProgress >= reqLapProgress)
        {
            //if it is, increase lap count and reset our current progress
            laps++; //increase laps by one
            lapProgress = 0; //resets lap progress
        }
        Debug.Log("current fuel: " + fuel);
        Debug.Log("Completed laps: " + laps);
        
    }
}
