using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public Transform  start;
    public GameObject enemy1;
    //public Transform finnish;

    public Transform[] pointss;

    private void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    private IEnumerator EnemySpawn()
    {
       
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1f);
            GameObject newObject = (Instantiate(enemy1, start));

            //newObject.GetComponent<NavMesh>().finish = finnish;
            newObject.GetComponent<NavMesh>().points = pointss;
        }
    }
}
