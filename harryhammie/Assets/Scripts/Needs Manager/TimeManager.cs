using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static float gameHourTimer = 0f;

    public float hourLenght;

    private void Update()
    {
        if (gameHourTimer <= 0)
        {
            gameHourTimer = hourLenght;
        }
        else
        {
            gameHourTimer -= Time.deltaTime;
        }
    }

}
