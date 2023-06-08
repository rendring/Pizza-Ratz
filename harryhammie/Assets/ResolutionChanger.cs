using UnityEngine;

public class ResolutionChanger : MonoBehaviour
{
    public int screenWidth = 1920;  // New screen width
    public int screenHeight = 1080; // New screen height

    void Start()
    {
        ChangeResolution();
    }

    public void ChangeResolution()
    {
        Screen.SetResolution(screenWidth, screenHeight, Screen.fullScreen);
    }
}
