using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public static int enemiesAlive;

    public Transform  start;
    //public GameObject enemy1;

    public Wave[] waves;

    private int enemyIndex = 0;
    private float timeBetweenWaves = 5f, countdown = 5f; 
    public Transform[] pointss;

    private void OnEnable()
    {
        enemiesAlive = 0;
    }

    private void Update()
    {
        if(enemiesAlive > 0)
        {
            return;
  
        }
      
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        countdown -= Time.deltaTime;
    }

    private IEnumerator SpawnWave()
    {
        Wave wave = waves[enemyIndex];

        for (int i = 0; i < wave.count; i++)
        {
            EnemySpawn(wave.enemy);
            yield return new WaitForSeconds(1f/ wave.rate);
        }

        enemyIndex++;
    }

    private void EnemySpawn(GameObject enemy)
    {
        GameObject newObject = (Instantiate(enemy, start));
        newObject.GetComponent<NavMesh>().points = pointss;

        enemiesAlive++;
    }
}
