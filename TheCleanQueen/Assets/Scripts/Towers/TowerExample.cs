using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerExample : MonoBehaviour
{
    public List<Enemies> enemies = new List<Enemies>();
    public Transform rotateKut;
    private float rotationSpeed = 10f;
    public int damage = 10;
    public float fireRate = 1.1f;

    public Enemies enemiess;

    private void Start()
    {
        InvokeRepeating("Attack", 0, fireRate);
    }
    void Update()
    {
        if (enemies == null)
        {
            return;
        }
        

        Vector3 dir = enemies[0].transform.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(rotateKut.rotation, lookRotation, Time.deltaTime * rotationSpeed).eulerAngles;
        rotateKut.rotation = Quaternion.Euler(0, rotation.y, 0);

    }

    public void RemoveEnemyFromList(Enemies thisEnemy)
    {
        enemies.Remove(thisEnemy);
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.transform.tag == "Enemy")
        {
            enemiess = other.transform.GetComponent<Enemies>();
            enemies.Add(enemiess);
            Debug.Log(enemiess.enemyHealth);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.transform.tag == "Enemy")
        {
            RemoveEnemyFromList(other.transform.GetComponent<Enemies>());
        }
    }

  

    public void Attack()
    {
        if (enemies.Count > 0)
        {
            enemies[0].DoDamage(damage);

        }
    }
}
