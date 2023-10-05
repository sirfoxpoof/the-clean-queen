using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuild : MonoBehaviour
{
    public static TowerBuild instance;

    private GameObject buildTower;
    public GameObject[] towerPrefabs;

    public TowerBuy koopjes;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.Log("teveel towerbuilds kut, mag er maar 1 zijn");
            return;
        }
        instance = this;
    }
    

    private void Update()
    {
        if (koopjes.towOne)
        {
            buildTower = towerPrefabs[0];
        }
        if (koopjes.towTwo)
        {
            buildTower = towerPrefabs[1];
        }
        if (koopjes.towThree)
        {
            buildTower = towerPrefabs[2];
        }
        if (koopjes.towFour)
        {
            buildTower = towerPrefabs[3];
        }
    }

    public GameObject GetBuildTower()
    {
        return buildTower;
    }
}
