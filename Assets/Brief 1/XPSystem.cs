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

    //XP rate variable
    public float earntXP = 2.0f;

        
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //three interactions to manipulate XP being earnt:
        
        //when the Left Mouse key is pressed it acts like a light attack button, earning xp with every hit/every click of the Left Mouse.
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GainXP(attack);
            Debug.Log("Light Attack!");
        }

        //when the Left Mouse key is pressed it acts like a heavy attack button, earning xp with every hit/every click of the Left Mouse.
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GainXP(attack * 2);
            Debug.Log("Heavy Attack!");
        }

        //when the "v" key is pressed it acts like a close slash/knife button, earning xp with every hit/every click of the Left Mouse.
        if (Input.GetKeyDown(KeyCode.V))
        {
            GainXP(attack * 1.2f);
            Debug.Log("Daggered!");
        }





        //when the "1" key is pressed on the numpad only Health will increase.
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            health += 10f;
            Debug.Log("OKAY OKAY! Cheat your health then! Health = " + health);
        }


        //when the "2" key is pressed on the numpad only defence will increase.
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            defence += 3f;
            Debug.Log("Extra defence is kinda unfair... Defence = " + defence);
        }


        //when the "3" key is pressed on the numpad only speed will increase.
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            speed += 15f;
            Debug.Log("Oh you only want to cheat for speed??? OKAY! Speed = " + speed);
        }


        //when the "4" key is pressed on the numpad only Attack will increase.
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            attack += 5f;
            Debug.Log("You're now a little too overpowered! Attack = " + attack);
        }


        //doesnt work yet :(    
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Work plz! I beg");
            ResetXD();
        }
    }


    //interaction called by button press
 /* public void Interaction(int exp)
    {

    } */   
    
    public void GainXP(float amount)
    {
        //increase our current xp
        curXP += amount;
        Debug.Log("Gained " + amount + " XP. Total XP is now: " + curXP);
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
    
    
    //improve our stats
    public void IncreaseStats()
    {
        //improve XP rate
        earntXP *= 1.5f; 
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
        Update();
    }
    


    public void ResetXD()
     {
        //reset health
        health = 10.0f;
        //reset defence
        defence = 6.0f;
        //reset speed
        speed = 5.0f;
        //reset attack
        attack = 2.0f;
        Debug.Log("Ha Ha! Youve Reset your stats XD! Health = " + health + ", Defence = " + defence + ", Speed = " + speed + ", Attack = " + attack + ".Good work champ!");
        Update();
    } 
    
            
}
