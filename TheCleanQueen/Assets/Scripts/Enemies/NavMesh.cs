using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    public Transform finish;

    private void Start()
    {
        
    }
    void Update()
    {
       NavMeshAgent agent = GetComponent<NavMeshAgent>();
       agent.destination = finish.position;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }
}
