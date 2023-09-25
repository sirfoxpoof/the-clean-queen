using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    public NavMesh nav;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy1"))
        {
            SpawnEnemy.enemiesAlive--;
            print("hoi");
            Destroy(gameObject);

            
        }
    }
}
