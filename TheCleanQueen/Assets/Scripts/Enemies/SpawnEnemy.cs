using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public Transform  start;
    public GameObject enemy1;
    public Transform finnish;

    public void OnPress()
    {
        GameObject newObject = (Instantiate(enemy1, start));
        newObject.GetComponent<NavMesh>().finish = finnish;
    }

}
