using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyCount : MonoBehaviour
{
    [SerializeField]
    private TMP_Text enemyCount, waveCount;
    public SpawnEnemy SpawnEnemy;

    void Update()
    {
        enemyCount.text = Mathf.Round(SpawnEnemy.enemiesAlive).ToString();
        waveCount.text = Mathf.Round(SpawnEnemy.waveIndex).ToString();
    }
}
