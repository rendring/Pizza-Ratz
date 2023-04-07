using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NeedController : MonoBehaviour
{
    public int food, happiness, hygiene;
    public int foodTickRate, happinessTickRate, hygieneTickRate;
    public static float gameHourTimer = 0f;

    public float hourLenght;


    public void Initialize(int food, int happiness, int hygiene)
    {
        this.food = food;
        this.happiness = happiness;
        this.hygiene = hygiene;
    }

    //why its not reconising the TimeManager (ask Niels)
    // 6/4/23: Ren H: changed private update to public, still unable to call variable in FeedScr
    private void Update()
    {
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



