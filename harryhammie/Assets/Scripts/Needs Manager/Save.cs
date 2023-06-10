using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
   private static Save dataInstance;
    
    void Awake(){
        DontDestroyOnLoad (this);
        
        // 19/5/23- Ren H: Prevents cloning
        if (dataInstance == null) {
            dataInstance = this;
        } else {
            DestroyObject(gameObject);
        }
    }
}
