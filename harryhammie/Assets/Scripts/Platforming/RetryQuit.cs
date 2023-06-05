using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryQuit : MonoBehaviour
{ 
    Scene currentScene;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }
    public void Quit()
    {
        SceneManager.LoadScene("Main");
    }
    public void Retry()
    {

        if (currentScene.name == "Level2")
        {
            SceneManager.LoadScene("Level2");
        }

        if (currentScene.name == "Level1")
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
