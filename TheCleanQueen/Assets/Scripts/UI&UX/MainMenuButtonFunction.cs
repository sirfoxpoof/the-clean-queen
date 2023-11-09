using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenuButtonFunction : MonoBehaviour
{
    public GameObject currentScreen, loadingScreen, settingsPanel;
    public Animator animatorSprite, animatorSlider;
    public string sceneName;


    public void Start()
    {
        settingsPanel.gameObject.SetActive(false);

        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ResetProgress(string levelToLoad)
    {
        currentScreen.SetActive(false);
        loadingScreen.SetActive(true);
        StartCoroutine(LoadLevelASync(levelToLoad));
    }


    IEnumerator LoadLevelASync(string levelToLoad)
    {
        Time.timeScale = 1;
        animatorSprite.Play("GirlRun");
        animatorSlider.Play("FakeLoadslider");
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);
        loadOperation.allowSceneActivation = false;
        yield return new WaitForSeconds(3);
        loadOperation.allowSceneActivation = true;
    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void QuitGame()
    {
        Application.Quit();
        print("quit");
    }
}






