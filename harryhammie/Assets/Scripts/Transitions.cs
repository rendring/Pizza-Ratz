using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    public GameObject DeathCall, DeathCall2, Finishtag;
    public bool Death = false;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Death = DeathCall.GetComponent<CountdownClock>().Death;

            if (DeathCall.GetComponent<CountdownClock>().ActualDeath == true)
            {
                Finishtag.SetActive(true);
            }
            if (Death == true)
            {
           
            DeathCall.SetActive(false);
            DeathCall2.SetActive(false);

        }
        
    }
}
