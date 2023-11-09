using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TowerExample : MonoBehaviour
{
    public List<Enemies> enemies = new List<Enemies>();
    public Transform rotateKut;
    private float rotationSpeed = 10f;

    public int damage = 10;
    public float fireRate = 1.1f;

    public Enemies enemiess;
    public Transform trash, spray;

    public Transform spawnVuilnisZak, vuilnis;
    public bool vuilnisHier;
/*
    public Transform spawnBullet;
    public GameObject bullet;
    private float speed = 2;
*/

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
        
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i] == null)
            {
                enemies.RemoveAt(i);
            }
        }
        if(enemies.Count > 0)
        {
            Vector3 dir = enemies[0].transform.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            Vector3 rotation = Quaternion.Lerp(rotateKut.rotation, lookRotation, Time.deltaTime * rotationSpeed).eulerAngles;
            rotateKut.rotation = Quaternion.Euler(0, rotation.y, 0);
        }
    }

    public void RemoveEnemyFromList(Enemies thisEnemy)
    {
        enemies.Remove(thisEnemy);
    }

    private void OnTriggerEnter(Collider other)
    { 
        //valt enemies aan als ze in range zijn
        if (other.transform.tag == "Enemy")
        {
            Attack();
            enemiess = other.transform.GetComponent<Enemies>();
            enemies.Add(enemiess);

            if (gameObject.CompareTag("Zeep"))
            {
                enemiess.enemySpeed *= 0.5f;
            }
           
        }
    }

    private void OnTriggerExit(Collider other)
    { 
        if (other.transform.tag == "Enemy")
        {
            RemoveEnemyFromList(other.transform.GetComponent<Enemies>());

            if (gameObject.CompareTag("Zeep"))
            {
                enemiess.enemySpeed = enemiess.enemies.speed;
            }
        }
    }

    public void Attack()
    {
        if (enemies.Count > 0)
        {
            enemies[0].DoDamage(damage, transform);

            if (transform.CompareTag("Spray"))
            {
                AirFreshener();
            }
            //ShootBullet();
        }
    }


    //Airfreshener

    void AirFreshener()
    {
        if (enemiess.inSprayRange)
        {
            enemiess.DoDamage(damage, transform);   
        }
    }

    public void PlaatsVuilnis ()
    {
        if (!vuilnisHier)
        {
            trash = Instantiate(vuilnis, spawnVuilnisZak);
            vuilnisHier = true;
            trash.GetComponent<Trash>().trashMoney = enemiess.enemyMoney;
            trash.GetComponent<Trash>().towerExample = this;
        }
        else
        {
            trash.GetComponent<Trash>().trashMoney += enemiess.enemyMoney;
            return;
        }
    }

  /*  void ShootBullet()
    {
        GameObject kog = Instantiate(bullet, spawnBullet.position, bullet.transform.rotation);
        Rigidbody rb = kog.GetComponent<Rigidbody>();

        rb.AddForce(spawnBullet.forward, ForceMode.Impulse);
        enemies[0].DoDamage(damage);

    }*/
}
