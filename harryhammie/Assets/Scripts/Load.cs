using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
   public float LoadTime = 6;
   public bool LoadDone = false;

   void Update(){
        if(LoadTime > 0){
            LoadTime -= Time.deltaTime;
        } else if(LoadTime <= 0){
            LoadDone = true;
        }
        if (LoadDone == true){
            SceneManager.LoadScene("TutorialStart");
        }
   }

}
