using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TowerBuild : MonoBehaviour
{
    public static TowerBuild instance;

    public int[] needMoney;
    public int neededMoney;

    private GameObject buildTower;
    public GameObject[] towerPrefabs;
    public GameObject selectedTowerPlacer;

    public bool towOne, towTwo, towThree, towFour;
    public IngameUI gameUI;

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
        if (towOne)
        {
            buildTower = towerPrefabs[0];
            neededMoney = needMoney[0];
        }
        if (towTwo)
        {
            buildTower = towerPrefabs[1];
            neededMoney = needMoney[1];
        }
        if (towThree)
        {
            buildTower = towerPrefabs[2];
            neededMoney = needMoney[2];
        }
        if (towFour)
        {
            buildTower = towerPrefabs[3];
            neededMoney = needMoney[3];
            
        }

    }


    public void BroomTower()
    {
        towOne = true;
        towTwo = false;
        towThree = false;
        towFour = false;
    }
    public void AirFreshenerTower()
    {
        towOne = false;
        towTwo = true;
        towThree = false;
        towFour = false;
    }
    public void HillyHooverTower()
    {
        towOne = false;
        towTwo = false;
        towThree = true;
        towFour = false;
    }
    public void SoapTower()
    {
        towOne = false;
        towTwo = false;
        towThree = false;
        towFour = true;
    }

    public GameObject GetBuildTower()
    {
        Debug.Log(buildTower);
        return buildTower;
    }
}
