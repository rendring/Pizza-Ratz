using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;

public class Scores : MonoBehaviour
{
    //Variables needed to keep track of score and to display it on the level success screen - Christiaan 23-05
    public float Score = 100f;
    public TMP_Text ScoreDisplayText;
    public TMP_Text HighScoreText;
    public GameObject Clock;
    bool CallOnce = false;
    

    //Bonuspoints based on how fast you complete the level -Christiaan 23-05
    [SerializeField]
    private float TimerPointBonus = 0;

    //Grab the data from the scriptable object to keep the high score -C 24-05
    [SerializeField]
    private PermaStates HighScoreInfo;
   
    [SerializeField]
    private float Highscore = 0;
   
    //Define the high score as the high score in the scriptable object on start so it doesn't reset to 0 every time you retry -C 24-05
    private void Start()
    {
        Highscore = HighScoreInfo.SuperAwesomeHighScore;

    }

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

            // Rounded to whole numbers rather than decimals -Christiaan 23-05
            int EndScore = (int)Mathf.Floor(Score);
            ScoreDisplayText.text = string.Format("{000}", EndScore);

            //Define the high score as the end score if it's lower -C 24-05
            if (Highscore < EndScore)
            {
                Highscore = EndScore;
                HighScoreInfo.SuperAwesomeHighScore = Highscore;
            }

            //Display High Score -C 24-05
            HighScoreText.text = string.Format("{000}", HighScoreInfo.SuperAwesomeHighScore);
           
        }
        


    }

} 
    

