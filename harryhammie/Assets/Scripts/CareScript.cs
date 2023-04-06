using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 30/3/23: Ren H- This is VERY important for accessing ui elements in script
using UnityEngine.UI;

public class CareScript : MonoBehaviour
{
   [SerializeField]
    private GameObject Food;
    private bool foodEnabled;

    void Start(){
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        foodEnabled = true;
    }

    private void TurnOnAndOff(){
        /* 4/4/2023: Ren H- Following code, not common practise & should not be used
        foodEnable ^= true; */
        if(foodEnabled == true){
            Food.SetActive(true);
            foodEnabled = false;
        } else {
            Food.SetActive(false);
            foodEnabled = true;
        }
    }
}
