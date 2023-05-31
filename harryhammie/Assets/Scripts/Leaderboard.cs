using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{

    //All the scores of others + the player
    public TMP_Text ShadowHarry, Garf, GarfB, Shmeeg, Plorgladle;
    public GameObject SHpos, GarfPos, GarfBPos, ShmeegPos, PlorgladlePos;
    public PermaStates HighScore;
    private int SHScore = 650;
    private int GarfScore = 550;
    private int GarfBScore = 450;
    private int ShmeegScore = 300;
    private int PlorgladleScore = 200;
    private float PlayerScore;

  
    void Start()
    {
        PlayerScore = HighScore.SuperAwesomeHighScore;
    }


    void Update()
    {
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
            GarfB.text = string.Format("Player: {0}", PlayerScore);
        }

       
       


    }
}
