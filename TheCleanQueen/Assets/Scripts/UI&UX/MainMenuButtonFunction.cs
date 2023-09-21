using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonFunction : MonoBehaviour
{
    public GameObject mainMenu, loadingScreen;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevelButton(string levelToLoad)
    {
        Debug.Log("buttonknop");
        mainMenu.SetActive(false);
        loadingScreen.SetActive(true);
        StartCoroutine(LoadLevelASync(levelToLoad));
        
    }

    IEnumerator LoadLevelASync(string levelToLoad)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);
        Debug.Log("async aan het doen");

        loadOperation.allowSceneActivation = false;
        yield return new WaitForSeconds(2f);
        loadOperation.allowSceneActivation = true;
 
    }
}






