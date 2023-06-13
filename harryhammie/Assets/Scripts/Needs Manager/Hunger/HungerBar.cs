using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{

    public Bar bar;
    // Reducing hunger needs based on game
    // 7/5/23: Ren H- the following variables com from the Time Manager Script
    public float gameHourTime;
    public float hourLenght;
    public Slider timeSlider;

    public PermaStates HungerBarS;

    //public float gameHourTime;

   // private bool stopTimer;

    void Start()
    {

       
        //stopTimer = false;
       // timeSlider.maxValue = gameHourTime;

        gameHourTime = HungerBarS.HungerBarSlider;
        timeSlider.value = gameHourTime;
        timeSlider.value = HungerBarS.HungerBarSlider;
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = gameHourTime - Time.time;

        gameHourTime -= Time.deltaTime;
        timeSlider.value = gameHourTime;

        HungerBarS.HungerBarSlider = timeSlider.value;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);
    }
}
