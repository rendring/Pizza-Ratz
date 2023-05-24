using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scores : MonoBehaviour
{
    //Variables needed to keep track of score and to display it on the level success screen - Christiaan 23-05
    public float Score = 100f;
    public TMP_Text ScoreDisplayText;
    public GameObject Clock;
    bool CallOnce = false;

    //Bonuspoints based on how fast you complete the level -Christiaan 23-05
    [SerializeField]
    private float TimerPointBonus = 0;


    void Update()
    {

        TimerPointBonus = Clock.GetComponent<CountdownClock>().timer;



        if (Clock.GetComponent<CountdownClock>().Death == true)
        {
            // Score calculation based on speed, booleans added so it only updates once -Christiaan 23-05
            if (CallOnce == false)
            {
                Score = Score * TimerPointBonus;
                CallOnce = true;
            }

            // Rounded to whole numbers rather than decimals
            int EndScore = (int)Mathf.Floor(Score);
            ScoreDisplayText.text = string.Format("{000}", EndScore);
        }



    }

} 
    

