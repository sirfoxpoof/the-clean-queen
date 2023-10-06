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

   /* public void LoadLevelButton(string levelToLoad)
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
    }*/
}






