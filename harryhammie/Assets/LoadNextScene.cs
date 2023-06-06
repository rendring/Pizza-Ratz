using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    private ButtonListManager listManager;

    private void Start()
    {
        listManager = FindObjectOfType<ButtonListManager>();
    }

    public void LoadNextScene()
    {
        listManager.LoadNextScene();
    }
}
