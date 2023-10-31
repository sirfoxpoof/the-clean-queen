using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBase : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Transform finish;

    public int health;
    public bool gameOver;

    public Movement move;
    public SpawnEnemy spawnEnemy;


    private void Start()
    {
        gameOverPanel.SetActive(false);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            move.enabled = false;
            spawnEnemy.enabled = false;
            gameOverPanel.SetActive(true);

            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
