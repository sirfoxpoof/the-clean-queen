using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class SpawnEnemy : MonoBehaviour
{
    public GameObject tutorialPanel, pressEPanel;
    public static int enemiesAlive;

    public Transform start;

    public WaveScribtableObject wavess;

    public TMP_Text waveCountDown;

    private int waveIndex = 0;
    public float timeBetweenWaves = 5f, countdown = 5f;

    public bool wavesClear;

    private void OnEnable()
    {
        wavesClear = false; 
        enemiesAlive = 0;
    }

    private void Update()
    {
        if (enemiesAlive > 0)
        {
            return;
        }

        if (countdown <= 0)
        {
            StartCoroutine(SpawnWave());

            countdown = timeBetweenWaves;
            return;
        }
          
          waveCountDown.text = Mathf.Round(countdown).ToString();
          //waveCountDown.text = string.Format("{0:00.00}", countdown);  

          countdown -= Time.deltaTime;
    }

    private IEnumerator SpawnWave()
    {
        if (wavess.waves.Length > waveIndex)
        {
            Wave wave = wavess.waves[waveIndex];

            for (int a = 0; a < wave.enemies.Length; a++)
            {
                for (int i = 0; i < wave.enemies[a].count; i++)
                {
                    EnemySpawn(wave.enemies[a].enemy);
                    yield return new WaitForSeconds(1f / wave.rate);
                }
            }
        }

        if (enemiesAlive <= 0)
        {
            wavesClear = true;
            this.enabled = false;
            Time.timeScale = 0;

            Currency.towerMoney = 10;

            tutorialPanel.SetActive(false);
            pressEPanel.SetActive(false);
        }
       


        waveIndex++;
        Debug.Log(waveIndex);
    }

    private void EnemySpawn(GameObject enemy)
    {
        GameObject newObject = (Instantiate(enemy, start));
        enemiesAlive++;
    }
}
