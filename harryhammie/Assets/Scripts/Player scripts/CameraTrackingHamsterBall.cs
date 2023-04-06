using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrackingHamsterBall : MonoBehaviour
{
    public Transform Ball;
    public Vector3 Offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Ball.position + Offset;
        
    }
}
