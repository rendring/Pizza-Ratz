using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public float LoadTime = 6;
    private bool LoadDone = false;
    
    // Update is called once per frame
    void Update()
    {
        if (LoadTime > 0){
            LoadTime -= Time.deltaTime;
        } else if (LoadTime <= 0){
            LoadDone = true;
        }

        if(LoadDone == true){
            SceneManager.LoadScene("Question");
        }
    }
}
