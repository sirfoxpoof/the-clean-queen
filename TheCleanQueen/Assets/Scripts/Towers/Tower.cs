using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private Transform tower;
    public Transform rotateKut;
    public int range = 4;
    private float enemyDistance, shortDistance;
    public float speed = 10f;

    private GameObject nearestEnemy;

   

    void Start()
    {
        InvokeRepeating("TowerUpdate", 0, 0.5f);
    }

    void TowerUpdate()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        shortDistance = Mathf.Infinity;
        nearestEnemy = null; 

        foreach (GameObject enemy in enemies)
        {
            enemyDistance = Vector3.Distance(transform.position, enemy.transform.position);

            if (enemyDistance < shortDistance)
            {
                shortDistance = enemyDistance;
                nearestEnemy = enemy;   
            }

            if(nearestEnemy != null && shortDistance <= range)
            {
                tower = nearestEnemy.transform;
            }
            else
            {
                tower = null;
            }
        }
    }
    void Update() 
    {
        if(tower == null)
        {
            return;
        }

        Vector3 dir = tower.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(rotateKut.rotation, lookRotation, Time.deltaTime * speed).eulerAngles;
        rotateKut.rotation = Quaternion.Euler(0, rotation.y, 0);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {
           TowerUpdate();
        }
    }
}
