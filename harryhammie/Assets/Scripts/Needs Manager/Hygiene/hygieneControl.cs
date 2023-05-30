using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hygieneControl : MonoBehaviour
{
    // 7/5/23:  Ren H- This will increase the hygiene bar when bath btn is clicked
    public GameObject HygieneInc;
    int bath = 0;
    public Slider slider;

    public void UpdateBath(){
        bath++;
        HygieneInc.GetComponent<HygieneBar>().gameHourTime = HygieneInc.GetComponent<HygieneBar>().gameHourTime + bath;
    }
}
