using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBase : MonoBehaviour
{
    public GameObject gameOverPanel;
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
            gameOver = true;
        }

        if(gameOver)
        {
            move.enabled = false;
            spawnEnemy.enabled = false;
            gameOverPanel.SetActive(true);

            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
