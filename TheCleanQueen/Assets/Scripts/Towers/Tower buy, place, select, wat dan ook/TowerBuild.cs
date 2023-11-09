using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TowerBuild : MonoBehaviour
{
    public static TowerBuild instance;
    public int[] needMoney;
    public GameObject[] towerPrefabs;
    public GameObject notEnoughMoney;
    public IngameUI gameUI;

    public TowerPlace currentTowerPlace;

    private void Start()
    {
        if(instance != null)
        {
            Debug.Log("Teveel towerbuilds kut, mag er maar 1 zijn.");
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    public void BuildThisTower(int towerIndex)
    {
        if(Currency.money >= needMoney[towerIndex])
        {
            currentTowerPlace.myTower = Instantiate(towerPrefabs[towerIndex], currentTowerPlace.placeHere);
            Currency.money -= needMoney[towerIndex];
            currentTowerPlace.usedMoney = needMoney[towerIndex];
            currentTowerPlace.towerPlaced = true;   
            currentTowerPlace = null;
        }
        else
        {
            notEnoughMoney.SetActive(true);
        }
    }
}
