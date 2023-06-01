using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackScr : MonoBehaviour
{
    // 29/4/23: Ren H- Back btn / move to interactions
    public void MovetoHarry(string sceneID){
        SceneManager.LoadScene("Main");
    }
}
