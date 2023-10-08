using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
   /* public Enemies emny;
    public TowerScribtableObject towers;

    private Transform enemy;
    public Transform rotateKut;
    public int range = 4;
    private float enemyDistance, shortDistance;
    public float speed = 10f;

    private GameObject nearestEnemy;
    private GameObject[] enemies;


    void Start()
    {
        InvokeRepeating("TowerUpdate", 0, 0.5f);
    }

    void TowerUpdate()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

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
                this.enemy = nearestEnemy.transform;
            }
            else
            {
                this.enemy = null;
            }

           
        }
    }

   *//* private IEnumerator DoDamage()
    {

        yield return new WaitForSeconds(0.5f);
        emny.enemyHealth -= towers.damage;
    }*//*

    void Update() 
    {
        if(enemy == null)
        {
            return;
        }

        Vector3 dir = enemy.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(rotateKut.rotation, lookRotation, Time.deltaTime * speed).eulerAngles;
        rotateKut.rotation = Quaternion.Euler(0, rotation.y, 0);

       // Debug.Log(enemies.health);
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
           // GetComponent<Enemies>
        }
    }*/
}
