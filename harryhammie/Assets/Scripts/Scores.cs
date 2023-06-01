using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{

    Scene currentScene;
    private string SceneName;
    //Variables needed to keep track of score and to display it on the level success screen - Christiaan 23-05
    public float Score = 100f;
    public float KoopzegelScore = 0f;
    public TMP_Text ScoreDisplayText;
    public TMP_Text HighScoreText;
    public GameObject Clock;
    public GameObject KoopzegelPoints;
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
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        SceneName = currentScene.name;

        if (SceneName == "Test level Gracjan")
        {

            Highscore = HighScoreInfo.SuperDuperAwesomeHighScore;
        }

            if (SceneName == "Level test")
        {
            Highscore = HighScoreInfo.SuperAwesomeHighScore;
        }

    }

    void Update()
    {
        
        TimerPointBonus = Clock.GetComponent<CountdownClock>().timer;



        if (Clock.GetComponent<CountdownClock>().Death == true)
        {


            // Score calculation based on speed (and amount of koopzegels collected -C 01-06), booleans added so it only updates once -Christiaan 23-05
            if (CallOnce == false)
            {
                Score = Score + KoopzegelScore;
              
                Score = Score * TimerPointBonus;
                
                CallOnce = true;
            }

            // Rounded to whole numbers rather than decimals -Christiaan 23-05
            int EndScore = (int)Mathf.Floor(Score);
            ScoreDisplayText.text = string.Format("{000}", EndScore);

            if (SceneName == "Level test")
            {
               

                //Define the high score as the end score if it's lower -C 24-05
                if (Highscore < EndScore)
                {
                    Highscore = EndScore;
                    HighScoreInfo.SuperAwesomeHighScore = Highscore;
                }
                //Display High Score -C 24-05
                HighScoreText.text = string.Format("{000}", HighScoreInfo.SuperAwesomeHighScore);
            }

            if (SceneName == "Test level Gracjan")
            {
    
                
                if (Highscore < EndScore)
                {
                    Highscore = EndScore;
                    HighScoreInfo.SuperDuperAwesomeHighScore = Highscore;
                }

                HighScoreText.text = string.Format("{000}", HighScoreInfo.SuperDuperAwesomeHighScore);
            }
           
           
        }


        Debug.Log(KoopzegelScore);
    }

} 
    

