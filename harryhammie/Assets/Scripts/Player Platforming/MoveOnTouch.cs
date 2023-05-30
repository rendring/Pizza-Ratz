using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnTouch : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0){
            // 24/5/23: Ren H- 0 = the first touch
            Touch touch = Input.GetTouch(0);
            /* 24/5/23: Ren H- touch.position grabs coordinates within screen & uses pixels. Objects grabs coordinates within world & uses units
            Transforming to units will automatically set touchPosition Z axis to the camera. To prevent this manually set the z position */
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            transform.position = touchPosition;
        }
    }
}
