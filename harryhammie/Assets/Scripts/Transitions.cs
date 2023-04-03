using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    public GameObject DeathCall;
    public bool Death = false;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Death = DeathCall.GetComponent<CountdownClock>().Death;
       if(Death == true)
        {
            gameObject.SetActive(false);
        }
    }
}
