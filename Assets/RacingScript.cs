using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingScript : MonoBehaviour
{
    int laps = 0;

    float curLapProgress = 0f;
    float reqLapProgress = 100f;

    float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GainProgress(speed);
        }
    }

    public void GainProgress(float progress)
    {
        curLapProgress += progress;
        Debug.Log("Gained " + progress + " progress");
        Debug.Log("Total current progress is now: " + curLapProgress);
        CheckProgress(curLapProgress);
    }

    void CheckProgress(float progress)
    {
        if (progress >= reqLapProgress)
        {
            //completed a lap
            Debug.Log("POG! You reached the required lap progress to go up a lap!");
            LapCompleted();
        }
    }

    public void LapCompleted()
    {
        //update laps
        laps += 1;
        //update curProgress
        curLapProgress = 0;
        //update requiredProgress
        reqLapProgress *= 1.25f;
        //update speed
        speed = 10f;

        Debug.Log("Y'all completed " + laps + " laps");

    }      
}