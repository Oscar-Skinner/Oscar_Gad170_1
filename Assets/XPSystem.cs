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


    public float maxLevels = 10;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //when the space key is pressed it acts like a hit button, earning xp with every hit/every click of the space bar.
            GainXP(earntXP / 2 + 1);
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            //when the "S" key is pressed only speed will increase.
            speed += 15f;
            Debug.Log("Oh you only want speed??? OKAY! Speed = " + speed);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            //when the "H" key is pressed only Health will increase.
            health += 10f;
            Debug.Log("OKAY OKAY! Cheat your health then! Health = " + health);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //when the "D" key is pressed only defence will increase.
            defence += 3f;
            Debug.Log("Extra defence coming right up ;) Defence = " + defence);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //when the "A" key is pressed only Attack will increase.
            attack += 5f;
            Debug.Log("You're now a little too overpowered! Attack = " + attack);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            earntXP += 0.1f;
            Debug.Log("Cheat! XP risen to " + earntXP);
        }

        //doesnt work yet :(    
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Work plz! I beg");
            ResetXD();
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
