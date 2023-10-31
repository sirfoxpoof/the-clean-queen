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
        StartCoroutine(LoadLevelASync(levelToLoad));
    }

    IEnumerator LoadLevelASync(string levelToLoad)
    {
        GameObject[] e = GameObject.FindGameObjectsWithTag("Enemy");
        for(int i = 0; i < e.Length; i++)
        {
            Destroy(e[i]);
        }
        Time.timeScale = 1;
        animatorSprite.Play("GirlRun");
        animatorSlider.Play("FakeLoadslider");
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);
        loadOperation.allowSceneActivation = false;
        yield return new WaitForSeconds(3);
        loadOperation.allowSceneActivation = true;
    }

}
