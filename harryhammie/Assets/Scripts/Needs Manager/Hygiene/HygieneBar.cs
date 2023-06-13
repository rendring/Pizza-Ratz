using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HygieneBar : MonoBehaviour
{
    // 7/5/23: Ren H- Reducing Hygiene needs based on game time
    // 7/5/23: Ren H- the following variables com from the Time Manager Script
    public float gameHourTime;
    public float hourLenght;
    public Slider timeSlider;

    public PermaStates HygieneBarS;

    void Start()
    {
        gameHourTime = HygieneBarS.HygieneBarSlider;
        timeSlider.value = gameHourTime;
        timeSlider.value = HygieneBarS.HygieneBarSlider;
    }

    // Update is called once per frame
    void Update()
    {
        float time = gameHourTime - Time.time;

        gameHourTime -= Time.deltaTime;
        timeSlider.value = gameHourTime;

        HygieneBarS.HygieneBarSlider = timeSlider.value;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);
    }
}
