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

    private void OnMouseDown(){
        Debug.Log("Harry is eating");
        // 8/6/23: Ren H- Disables food when it is clicked
        Food.SetActive(false);
        // 8/6/23: Ren H- Disables Arrow UI buttons when food is clicked
        Options.SetActive(false);
    }
}
