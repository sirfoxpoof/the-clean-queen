using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public TowerExample towerExample;
    public Swing swingTower;
    public int trashMoney = 0;

    private void Start()
    {
        towerExample = GetComponentInParent<TowerExample>();
        trashMoney = 0;
    }

    public void RemoveFromTower()
    {
        if (towerExample != null)
        {
            towerExample.vuilnisHier = false;
        }
        else
        {
            swingTower.hierVuilnis = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trashcan")
        {
            Currency.money += trashMoney;
            Destroy(gameObject);
        }
    }
}
