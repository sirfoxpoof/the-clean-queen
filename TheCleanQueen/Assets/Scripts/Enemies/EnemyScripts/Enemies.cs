        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public SpawnScribtableObject enemies;
    //public TowerScribtableObject towers;

    public int enemyHealth, enemyDamage;
    public float speed, turn = 10;
    private Transform target;
    private int waypoint = 0;

    Vector3 dir;

    private void Awake()
    {
        target = Waypoints.points[0];
        enemyHealth = enemies.health;
        enemyDamage = enemies.damage;
    }


    private void Update()
    {
        dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemies.speed * Time.deltaTime, Space.World);
        //transform.localRotation = Quaternion.Euler(transform.forward * turn * Time.deltaTime);
        transform.LookAt(target.position * turn * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) <= 0.1f)
        {
            NextWaypoint();
        }
    }

    void NextWaypoint()
    {
        if(waypoint >= Waypoints.points.Length - 1)
        {
            SpawnEnemy.enemiesAlive--;
            Destroy(gameObject);
            return;
        
        }
        waypoint++;
        target = Waypoints.points[waypoint];   
    }

    void Die()
    {
        Destroy(gameObject);
    }

    public void DoDamage(int damage)
    {
        enemyHealth -= damage;
        if(enemyHealth <= 0)
        {
            Die();
        }
    }
   
}

