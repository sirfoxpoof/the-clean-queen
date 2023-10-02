        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public SpawnScribtableObject enemies;
    public TowerScribtableObject towers;

    public float speed, turn;
    private Transform target;
    private int waypoint = 0;

    Vector3 dir;

    private void Awake()
    {
        target = Waypoints.points[0];
    }

    private void Update()
    {
        dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemies.speed * Time.deltaTime, Space.World);
        transform.localRotation = Quaternion.Euler( dir.normalized * turn * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) <= 0.1f)
        {
            NextWaypoint();
        }

        Debug.Log(enemies.health);
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tower"))
        {
            enemies.health -= towers.damage;
        }

        if(enemies.health <= 0)
        {
            Destroy(gameObject); 
            return;
        }
    }
}

