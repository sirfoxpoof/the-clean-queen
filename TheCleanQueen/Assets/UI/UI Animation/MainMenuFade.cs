using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenuFade : MonoBehaviour
{
    public Animator animator;
    public GameObject animator2, levelSelect, mainMenu;

    private void Start()
    {
        animator2.GetComponent<Animator>().enabled = false;
        levelSelect.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void StartButton()
    {
        animator2.GetComponent<Animator>().enabled = true;
        animator.Play("Flashbang");
        StartCoroutine(Wait());
        

    }
    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        mainMenu.SetActive(false);
        levelSelect.SetActive(true);

    }

}
