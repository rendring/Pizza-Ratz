using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leaderboard : MonoBehaviour
{

    //All the scores of others + the player
    public TMP_Text ShadowHarry, Garf, GarfB, Shmeeg, Plorgladle;
    public GameObject SHpos, GarfPos, GarfBPos, ShmeegPos, PlorgladlePos;
    public PermaStates HighScore;

    Scene currentScene; 
    private int SHScore;
    private int GarfScore;
    private int GarfBScore;
    private int ShmeegScore;
    private int PlorgladleScore;
    private float PlayerScore;
    private string SceneName;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        SceneName = currentScene.name;


        if (SceneName == "Level test")
        {
            PlayerScore = HighScore.SuperAwesomeHighScore;
        }

        if (SceneName == "Test level Gracjan")
        {
            PlayerScore = HighScore.SuperDuperAwesomeHighScore;
        }
    }


    void Update()
    {
        if (SceneName == "Level test")
        {
            SHScore = 650;
            GarfScore = 550;
            GarfBScore = 450;
            ShmeegScore = 300;
            PlorgladleScore = 200;
        }

        if (SceneName == "Test level Gracjan")
        {
            SHScore = 1800;
            GarfScore = 1700;
            GarfBScore = 1500;
            ShmeegScore = 1100;
            PlorgladleScore = 900;


        }
        ShadowHarry.text = string.Format("Shadow Harry: {0}", SHScore);
        Garf.text = string.Format("Garf: {0}", GarfScore);
        GarfB.text = string.Format("Garf's brother: {0}", GarfBScore);
        Shmeeg.text = string.Format("Shmeeg: {0}", ShmeegScore);
        Plorgladle.text = string.Format("Plorglade: {0}", PlorgladleScore);


       

       
        if (PlayerScore >= PlorgladleScore && PlayerScore < ShmeegScore)
        {
            Plorgladle.text = string.Format("Player: {0}", PlayerScore);
        }

        if (PlayerScore >= ShmeegScore && PlayerScore < GarfBScore)
        {
            Shmeeg.text = string.Format("Player: {0}", PlayerScore);
        }

        if (PlayerScore >= GarfBScore && PlayerScore < GarfScore)
        {
            GarfB.text = string.Format("Player: {0}", PlayerScore);
        }

        if (PlayerScore >= GarfScore && PlayerScore < SHScore)
        {
            Garf.text = string.Format("Player: {0}", PlayerScore);
        }

        if (PlayerScore >= SHScore)
        {
            ShadowHarry.text = string.Format("Player: {0}", PlayerScore);
        }

       
       


    }
}
