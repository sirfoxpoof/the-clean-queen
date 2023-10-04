using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBase : MonoBehaviour
{
    public GameObject baseProtect, gameOverPanel;
    public Transform finish;

    public int health, emnyDamage;
    private bool gameOver;

    public Movement move;
    public SpawnEnemy spawnEnemy;
    public Enemies enemies;


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

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            health -= enemies.enemyDamage;
        }
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
