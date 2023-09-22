using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenuButtonFunction : MonoBehaviour
{
    public GameObject menu, loadingScreen, settingsPanel, eventSystem;
    public bool settingsAan = false;
    public string sceneName;

    public void Start()
    {
        settingsPanel.gameObject.SetActive(false);
        eventSystem.SetActive(true);

        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        Cursor.lockState = CursorLockMode.None;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevelButton(string levelToLoad)
    {
        Debug.Log("buttonknop");
        menu.SetActive(false);
        loadingScreen.SetActive(true);
        

        StartCoroutine(LoadLevelASync(levelToLoad));
        
    }

    IEnumerator LoadLevelASync(string levelToLoad)
    {
        
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);
        Time.timeScale = 1;
        loadOperation.allowSceneActivation = false;
        yield return new WaitForSeconds(2f);
        
        loadOperation.allowSceneActivation = true;
        

    }


    
    public void DoSettingsMenu(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("WERK NOU MEE JEZUS");

            if (!settingsAan)
            {
                SettingsMenuOn();
            }
            else
            {
                SettingsMenuOff();

            }
            settingsAan = !settingsAan;
        }
    }

    public void SettingsMenuOn()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        settingsPanel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }


    public void SettingsMenuOff()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        settingsPanel.gameObject.SetActive(false);
        Time.timeScale = 1;

    }
    
}






