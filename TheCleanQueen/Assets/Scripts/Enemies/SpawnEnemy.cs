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

    private void OnEnable()
    {
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
            for (int z = 0; z < wave.enemies.Length; z++)
            {
                for (int i = 0; i < wave.enemies[z].count; i++)
                {
                    EnemySpawn(wave.enemies[z].enemy);
                    yield return new WaitForSeconds(1f / wave.rate);
                }
            }
            enemyIndex++;
        }
        else
        {
            this.enabled = false;
        }
        /*Wave wave = waves[enemyIndex];

        for (int i = 0; i < wave.count; i++)
        {
            EnemySpawn(wave.enemy);
            yield return new WaitForSeconds(1f/ wave.rate);
           
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
