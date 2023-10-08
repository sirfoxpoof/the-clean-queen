using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public SpawnScribtableObject enemies;
    public int enemyHealth, enemyDamage;
   
    private Transform target;
    private int waypoint = 0;

    Vector3 dir;
    MainBase basis;

    private void Awake()
    {
        target = Waypoints.points[0];
        enemyHealth = enemies.health;
        enemyDamage = enemies.damage;

        basis = GameObject.Find("Finish").GetComponent<MainBase>();
    }


    private void Update()
    {
        dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemies.speed * Time.deltaTime, Space.World);
        transform.LookAt(target.position, dir.normalized);

        if (Vector3.Distance(transform.position, target.position) <= 0.1f)
        {
            NextWaypoint();
        }
    }

    void NextWaypoint()
    {
        if(waypoint >= Waypoints.points.Length - 1)
        {
            basis.TakeDamage(enemyDamage);
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
            SpawnEnemy.enemiesAlive--;
        }
    }
   
}

