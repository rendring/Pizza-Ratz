using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickCamera : MonoBehaviour
{
    public Joystick joystick;


    private void Update()
    {
        HorInput = joystick.Horizontal;
    }






}




