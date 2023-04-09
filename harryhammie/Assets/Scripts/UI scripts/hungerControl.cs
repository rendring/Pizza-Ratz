using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hungerControl : MonoBehaviour
{
    // 9/4/23- Ren H: setting up to change on btn click
    int feed = 0;
    public Slider slider;

    public void UpdateFeed(){
        feed++;
        slider.value = feed;
    }

}
