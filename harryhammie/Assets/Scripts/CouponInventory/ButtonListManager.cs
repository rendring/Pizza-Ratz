using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class ButtonListManager : MonoBehaviour
{
    public List<Button> buttonList = new List<Button>();

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void OnButtonClick(Button button)
    {
        // Perform actions when a button is clicked
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("BathScene");
    }
}
