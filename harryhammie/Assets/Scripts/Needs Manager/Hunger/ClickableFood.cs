using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableFood : MonoBehaviour
{
    public GameObject Food;
    private bool foodEnabled;

    void Start(){
        foodEnabled = true;
    }

    private void OnMouseDown(){
        if(foodEnabled == true){
            Debug.Log("Harry is Eating");
            Food.SetActive(false);

        }
    }
}
