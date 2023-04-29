using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 30/3/23: Ren H- This is VERY important for accessing ui elements in script
using UnityEngine.UI;


public class NeedController : MonoBehaviour
{
    // setting up the needs 
    public int food, happiness, hygiene;
    public int foodTickRate, happinessTickRate, hygieneTickRate;
    
    //setting up the timer for decreasing needs
    public static float gameHourTimer = 0f;
    public float hourLenght;


    public void Initialize(int food, int happiness, int hygiene)
    {
        this.food = food;
        this.happiness = happiness;
        this.hygiene = hygiene;
    }

    //why its not reconising the TimeManager (ask Niels)
    private void Update()
    {
        // decreasing needs over time
        if (gameHourTimer <= 0)
        {
            ChangeFood(-foodTickRate);
            ChangeHappiness(-happinessTickRate);
            ChangeHygiene(-hygieneTickRate);

            gameHourTimer = hourLenght;
        }
        else
        {
            gameHourTimer -= Time.deltaTime;
        }

    }

    public void ChangeFood(int amount)
    {
        food += amount;
    }

    public void ChangeHappiness(int amount)
    {
        happiness += amount;
    }

    public void ChangeHygiene(int amount)
    {
        hygiene += amount;
    }
}



