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

        if (currentScene.name == "Level test")
        {
            SceneManager.LoadScene("Level test");
        }

        if (currentScene.name == "Test level Gracjan")
        {
            SceneManager.LoadScene("Test level Gracjan");
        }
    }
}
