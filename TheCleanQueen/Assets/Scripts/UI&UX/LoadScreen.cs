using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour
{
    public GameObject loadingScreen, menuScreen;
    public Slider loadprogressSlider;
    public float progressValue;
    public Animator animatorSprite, animatorSlider;

    public void LoadLevelButton(string levelToLoad)
    {
        menuScreen.SetActive(false);
        loadingScreen.SetActive(true);
        Time.timeScale = 1;
        StartCoroutine(LoadLevelASync(levelToLoad));
    }

    IEnumerator LoadLevelASync(string levelToLoad)
    {
        animatorSprite.Play("GirlRun");
        animatorSlider.Play("FakeLoadslider");

        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);

        loadOperation.allowSceneActivation = false;
        yield return new WaitForSeconds(3f);
        loadOperation.allowSceneActivation = true;



        /*while (!loadOperation.isDone)
        {
            progressValue = Mathf.Clamp01(loadOperation.progress / 0.9f);
            loadprogressSlider.value = progressValue;
            

        }*/
    }

}
