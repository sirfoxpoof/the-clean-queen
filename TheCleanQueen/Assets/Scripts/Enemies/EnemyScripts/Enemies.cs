using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public SpawnScribtableObject enemies;
    public int enemyHealth, enemyDamage, enemyMoney;
    public float enemySpeed;

    private Transform target;
    private int waypoint = 0;

    Vector3 dir;
    MainBase basis;

    public bool isDead = false;

    public Vector3 startSize;
    private Vector3 endSize;
    public float shrinkFactor = 0.1f;
    private float startHealth;
    private float enemyMinSize = 0.25f;
    public bool inSprayRange = false;

    private void Start()
    {
        target = Waypoints.points[0];
        enemyHealth = enemies.health;
        enemySpeed = enemies.speed;
        enemyDamage = enemies.damage;
        enemyMoney = enemies.coins;

        basis = GameObject.Find("Finish").GetComponent<MainBase>();
        startSize = transform.localScale;
        endSize = startSize * shrinkFactor;
        startHealth = enemyHealth;
    }


    private void Update()
    {
        dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemySpeed * Time.deltaTime, Space.World);
        transform.LookAt(target.position, dir.normalized);

        if (Vector3.Distance(transform.position, target.position) <= 0.1f)
        {
            NextWaypoint();
        }
    }

    void NextWaypoint()
    {
        if (waypoint >= Waypoints.points.Length - 1)
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
        if (isDead)
        {
            return;
        }
        isDead = true;

        //Currency.money += enemyMoney;

        SpawnEnemy.enemiesAlive--;
        Destroy(gameObject);
    }

    public void DoDamage(int damage, Transform tower)
    {
        enemyHealth -= damage;

        float t = (((enemyHealth - 0f) * (1f - enemyMinSize)) / (startHealth - 0f)) + enemyMinSize;
        t = Mathf.Clamp01(t);
        transform.localScale = new Vector3(t, t, t);

        if (enemyHealth <= 0)
        {
            if (tower.CompareTag("Tower") || tower.CompareTag("Zeep") || tower.CompareTag("Spray"))
            {
                tower.GetComponent<TowerExample>().PlaatsVuilnis();
            }
            else if (tower.CompareTag("Swing"))
            {
                tower.GetComponent<Swing>().PlaatsVuilnis();
            }
            Die();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("SpraySpray"))
        {
            inSprayRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("SpraySpray"))
        {
            inSprayRange = false;
        }
    }
}

