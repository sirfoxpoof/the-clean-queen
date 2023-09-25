using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    public Transform finish;

    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        GoToNextPoint();
    }
    void Update()
    {
       agent = GetComponent<NavMeshAgent>();
       agent.destination = points[destPoint].position;

        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GoToNextPoint();
        }
    }

    void GoToNextPoint()
    {
        destPoint = (destPoint + 1) % points.Length;
        agent.destination = points[destPoint].position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            SpawnEnemy.enemiesAlive--;
            Destroy(gameObject);
           
        }
    }
}
