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
    
    public void Interaction(int exp)
    {
        //interaction called by button press
        
    }    
    
    public void GainXP(float amount)
    {
        //increase our current xp
        curXP += amount;
        Debug.Log("Gained " + amount + " XP");
        Debug.Log("Total XP is now: " + curXP);
        InitialStats(curXP);
    }

    public void InitialStats(float amount)
    {
        //initial stats, level, xp, reqxp, etc...
        if (amount >= reqXP)
        {
            Debug.Log("Epic! You reached a new level!");
                LevelUp();
        }
    }

    public void LevelUp()
    {
        //increase our level
        level += 1;
        //reset current to 0
        curXP = 0;
        //increase reqXP
        reqXP *= 1.2f;
        Debug.Log("You're now Level " + level + "! Congrats!");
        IncreaseStats();
    }
    
    public void IncreaseStats()
    {
        //improve our stats
        //improves the health by 5
        health += 5.0f;
        //improves the defence by 1.
        defence += 1.0f;
        //improves the speed by 10% of original.
        speed *= 1.1f;
        //improves the attack by 2.
        attack += 2.0f;
        Debug.Log("Your new stats are:");
            Debug.Log("Health = " + health + ", Defence = " + defence + ", Speed = " + speed + ", Attack = " + attack + ". Good work champ!");
}
    
    
            
}
