using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 5/6/2023: Ren H- This is important to make foods clickable
using UnityEngine.Events;

public class ClickableFood : MonoBehaviour
{
    [SerializeField]
    private GameObject Food;
    private bool foodEnabled;

    void Start(){
        foodEnabled = false;
    }
    
    private void OnMouseDown(){
        if(foodEnabled == false){
            Food.SetActive(false);
            foodEnabled = true;
        }
        Debug.Log("Harry is eating food");
    }
}
