using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class SpawnEnemy : MonoBehaviour
{
    public static int enemiesAlive;

    public Transform start;

    public Wave[] waves;

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
          //waveCountDown.text = string.Format("{0:00.0}", countdown);  

          countdown -= Time.deltaTime;
    }

    private IEnumerator SpawnWave()
    {
        if (waves.Length > waveIndex)
        {
            Wave wave = waves[waveIndex];

            for (int a = 0; a < wave.enemies.Length; a++)
            {
                for (int i = 0; i < wave.enemies[a].count; i++)
                {
                    EnemySpawn(wave.enemies[a].enemy);
                    yield return new WaitForSeconds(1f / wave.rate);
                }
            }
        }
        else
        {
            if (enemiesAlive <= 0)
            {
                wavesClear = true;
            }
            this.enabled = false;
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
