using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryQuit : MonoBehaviour
{

    public void Quit()
    {
        SceneManager.LoadScene("harryHamster");
    }
    public void Retry()
    {
        SceneManager.LoadScene("TestLevelBallGame");
    }
}
