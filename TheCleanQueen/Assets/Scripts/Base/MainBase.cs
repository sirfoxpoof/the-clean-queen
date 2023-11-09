using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBase : MonoBehaviour
{
    public GameObject gameOverPanel, bed;
    public Material viesMaterial; 
    public Transform finish;

    [SerializeField]
    private int health, halfHealth;

    public Movement move;
    public SpawnEnemy spawnEnemy;


    private void Start()
    {
        gameOverPanel.SetActive(false);
        halfHealth = health / 3;
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
        if (health <= halfHealth)
        {
            bed.GetComponent<MeshRenderer>().material = viesMaterial;
        }
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
