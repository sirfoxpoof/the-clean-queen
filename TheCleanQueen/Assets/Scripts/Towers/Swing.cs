using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public int swingDamage = 5;
    Enemies enemies;

    public Transform spawnVuilnisZak, vuilnis, trash;
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
            trash = Instantiate(vuilnis, spawnVuilnisZak);
            hierVuilnis = true;
            trash.GetComponent<Trash>().trashMoney = enemies.enemyMoney;
            trash.GetComponent<Trash>().swingTower = this;
        }
        else
        {
            trash.GetComponent<Trash>().trashMoney += enemies.enemyMoney;
            return;
        }
    }
}
