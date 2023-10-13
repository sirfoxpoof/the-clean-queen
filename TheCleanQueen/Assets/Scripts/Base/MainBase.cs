using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBase : MonoBehaviour
{
    public GameObject baseProtect, gameOverPanel, tutorialPanel, pressEPanel;
    public Transform finish;

    public int health;
    private bool gameOver;

    public Movement move;
    public SpawnEnemy spawnEnemy;


    private void Start()
    {
        gameOverPanel.SetActive(false);
    }
    void Update()
    {
        if(health <= 0)
        {
            Destroy(baseProtect);
            gameOver = true;
        }

        if(gameOver)
        {
            move.enabled = false;
            spawnEnemy.enabled = false;
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
            tutorialPanel.SetActive(false);
            pressEPanel.SetActive(false);


            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Destroy(baseProtect);
        }
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
