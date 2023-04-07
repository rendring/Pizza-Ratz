using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//6/4/23: Ren H- This is VERY important for changing scenes with script
using UnityEngine.SceneManagement;


public class PlayScr : MonoBehaviour
{
    // 6/4/23: Ren H- Play btn / move to game
    public void MovetoScene(string sceneID){
        SceneManager.LoadScene("TestLevelBallGame");
    }
}
