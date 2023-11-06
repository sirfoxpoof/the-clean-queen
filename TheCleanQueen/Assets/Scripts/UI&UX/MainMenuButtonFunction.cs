using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenuButtonFunction : MonoBehaviour
{
    public GameObject /*menu, loadingScreen,*/ settingsPanel;
    public string sceneName;


    public void Start()
    {
        settingsPanel.gameObject.SetActive(false);

        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        Cursor.lockState = CursorLockMode.None;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}






