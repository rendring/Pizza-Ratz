using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;

public class hungerControl : MonoBehaviour
{
    // 9/4/23- Christiaan: connecting this script to the hungerbar script
    public GameObject HungerBarScript;
    // 9/4/23- Ren H: setting up to change on btn click
    int feed = 5;
    public Slider sliderH;
    public float GameHourTimeH;


    void Update()
    {

        //9/4/23 Christiaan: Defining the sliderH variable as the timeslider variable in HungerBar
        sliderH = HungerBarScript.GetComponent<HungerBar>().timeSlider;
        

       

    }


    //9/4/23 Christiaan: making it so the button actually fucking works (i have lost many braincells)
    public void UpdateFeed(){
        sliderH.value = sliderH.value + feed;
        HungerBarScript.GetComponent<HungerBar>().gameHourTime = sliderH.value;

        Debug.Log(GameHourTimeH);
    }

}
