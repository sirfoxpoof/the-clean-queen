        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed;
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
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

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
}

