using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedScr : MonoBehaviour
{
    [SerializeField]
    private GameObject Food;
    private bool foodEnabled;
    
    // 6/4/23: Ren H- for increasing food bar on feed btn press (not working): private int ChangeFood;


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
            /* 6/4/23: Ren H- Bar Intergration (Test 2): ChangeFood += 10; */
            /* 6/4/23: Ren H- Bar Intergration (Test 1): Error says script is unavailable: script.ChangeFood + 1; script.NeedController.ChangeFood + 1; */
        } else if(foodEnabled == false){
            Food.SetActive(false);
            foodEnabled = true;
        }
    }

    /* 6/4/23: Ren H- Bar Intergration (Test 2): Error stated that ChangeFood already existed/was called: public int ChangeFood(){    
        return food;}*/
}
