using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickFood : MonoBehaviour
{
    [SerializeField]
    private GameObject Food;
    [SerializeField]
    private GameObject Options;

    public GameObject Hungerbar;
    public Slider Slider;

    int feed = 0;
    //24-05- C: Have to add a boolean so I can detect when the function gets activated
    public bool FeedActive = false;


    private void OnMouseDown(){
        Debug.Log("Harry is eating");
        // 8/6/23: Ren H- Disables food when it is clicked
        Food.SetActive(false);

        feed++;
        Hungerbar.GetComponent<HungerBar>().gameHourTime = Hungerbar.GetComponent<HungerBar>().gameHourTime + feed;


        FeedActive = true;
        // 8/6/23: Ren H- Disables Arrow UI buttons when food is clicked
        Options.SetActive(false);
    }
}
