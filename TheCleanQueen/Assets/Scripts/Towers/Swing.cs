using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public int swingDamage = 5;
    Enemies enemies;

    public Transform spawnVuilnisZak, vuilnis;
    public bool hierVuilnis;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {
            enemies = other.transform.GetComponent<Enemies>();
            Attack();
        }
    }

    public void Attack()
    {
         enemies.DoDamage(swingDamage, transform);
    }

    public void PlaatsVuilnis()
    {
        if (!hierVuilnis)
        {
            Instantiate(vuilnis, spawnVuilnisZak);
            hierVuilnis = true;
        }
        else
        {
            return;
        }
    }
}
