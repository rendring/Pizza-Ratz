using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownClock : MonoBehaviour
{
    public bool Death = false;
    public float timer = 120;
    public TMP_Text TimerDisplayText;
   public bool ActualDeath = false;
   
 
    void Update()
    {

 
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = 0;
        }
        DisplayTimer(timer);
        if(timer <= 0)
        {
           
            Death = true;
            ActualDeath = true;
        }
        if (Death == true)
        {
            gameObject.SetActive(false);
        }

    }

    void DisplayTimer(float TimeToDisplay)
    {
        if(TimeToDisplay < 0)
        {
            TimeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(TimeToDisplay / 60);
        float seconds = Mathf.FloorToInt(TimeToDisplay % 60);

        TimerDisplayText.text = string.Format("{0:00}:{1:00}",minutes,seconds);
    }
}
