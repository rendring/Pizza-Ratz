using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragDrop : MonoBehaviour
{
   // 30/5/2023: Ren H-  Increase Harry fall speed
    Rigidbody HarryBod;
    public float Thrust = -50f;

    void Start (){
        HarryBod = GetComponent<Rigidbody>();
    }

    void Update(){
        HarryBod.AddForce(transform.up * Thrust);
    }
    // 31/5/2023: Ren H- Drag Harry around
    Vector3 mousePosition;
    private Vector3 GetMousePos()
    {
        // 9/5/23: Ren H- Transforms position from world to the screen
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }
}
