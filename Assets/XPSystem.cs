using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem : MonoBehaviour
{
    public int level = 1; //laps
    
    public float curXP = 0.0f; //curLapProgress
    public float reqXP = 20.0f; //reqLapProgress
    
    //stat variables (to be tracked and modified)
    public float health = 10.0f;
    public float defence = 6.0f;
    public float speed = 5.0f;
    public float attack = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GainXP(attack);
        }
    }

    public void GainXP(float amount)
    {
        //increase our current xp
        curXP += amount;
        Debug.Log("Gained " + amount + " XP");
        Debug.Log("Total XP is now: " + curXP);
    }

    public void InitialStats()
    {
        //initial stats, level, xp, reqxp, etc...
    }

    public void Interaction(int exp)
    {
        //interaction called by button press
    }    

    public void LevelUp()
    {
        //increase our level

    }

    public void IncreaseStats()
    {
        //improve our stats

    }
}
