using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BathScr : MonoBehaviour
{
    // 29/4/23: Ren H bath btn / move to bath
    public void MovetoBath(string sceneID){
        SceneManager.LoadScene("BathScene");
    }
}
