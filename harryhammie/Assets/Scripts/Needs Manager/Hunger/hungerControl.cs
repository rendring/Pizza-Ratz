using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hungerControl : MonoBehaviour
{
    // 7/5/23: Ren H- This will increase the hunger bar when feed btn is clicked (made by Christiaan)
    public GameObject FeedInc;
    // 9/4/23- Ren H: setting up to change on btn click
    int feed = 0;
    public Slider slider;

    //24-05- C: Have to add a boolean so I can detect when the function gets activated
    public bool FeedActive = false;
    
    
    public void UpdateFeed(){
        feed++;
        FeedInc.GetComponent<HungerBar>().gameHourTime = FeedInc.GetComponent<HungerBar>().gameHourTime + feed;

        
        FeedActive = true;
       
    }

}
