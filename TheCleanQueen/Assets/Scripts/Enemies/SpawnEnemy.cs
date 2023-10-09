using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public static int enemiesAlive;

    public Transform start;

    public Wave[] waves;

    private int enemyIndex = 0;
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

        countdown -= Time.deltaTime;
        //Debug.Log(countdown);
    }

    private IEnumerator SpawnWave()
    {

        if (waves.Length > enemyIndex)
        {
            Wave wave = waves[enemyIndex];

            for (int a = 0; a < wave.enemies.Length; a++)
            {
                for (int i = 0; i < wave.enemies[a].count; i++)
                {
                    EnemySpawn(wave.enemies[a].enemy);
                    yield return new WaitForSeconds(1f / wave.rate);
                }
            }
            enemyIndex++;
        }
        else
        {
            if(enemiesAlive <= 0)
            {
                wavesClear = true;
            }
            this.enabled = false;
        }
        /*Wave wave = waves[enemyIndex];

        for (int i = 0; i < wave.count; i++)
        {
            EnemySpawn(wave.enemy);
            yield return new WaitForSeconds(1f / wave.rate);

        }

        enemyIndex++;*/


        Debug.Log(enemyIndex);
    }

    private void EnemySpawn(GameObject enemy)
    {
        GameObject newObject = (Instantiate(enemy, start));

        enemiesAlive++;
    }
}
