using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    private ButtonListManager listManager;

    private void Start()
    {
        listManager = FindObjectOfType<ButtonListManager>();
        listManager.buttonList.Add(GetComponent<Button>());
    }

    public void OnButtonClick()
    {
        listManager.OnButtonClick(GetComponent<Button>());
    }
}
