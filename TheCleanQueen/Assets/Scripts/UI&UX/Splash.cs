using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    public AudioSource schwing;
    private void Start()
    {

        StartCoroutine(SplashScreen());
        StartCoroutine(PlaySound());

    }
    public IEnumerator SplashScreen()
    {

        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("MainMenu");
    }

    public IEnumerator PlaySound()
    {
        yield return new WaitForSeconds(0.5f);
        schwing.Play();
    }

}
