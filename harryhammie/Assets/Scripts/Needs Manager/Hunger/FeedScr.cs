using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedScr : MonoBehaviour
{
    [SerializeField]
    private GameObject Food;
    private bool foodEnabled;

    void Start(){
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        foodEnabled = true;
    }

    //6/4/23: Ren H- on & off switch for making food appear
    private void TurnOnAndOff(){
        /* 4/4/2023: Ren H- Following code, not common practise & should not be used: foodEnable ^= true; */
        if(foodEnabled == true){
            Food.SetActive(true);
            foodEnabled = false;
        } else if(foodEnabled == false){
            Food.SetActive(false);
            foodEnabled = true;
        }
    }
}
