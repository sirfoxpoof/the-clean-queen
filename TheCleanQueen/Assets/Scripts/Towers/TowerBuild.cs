using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuild : MonoBehaviour
{
    public static TowerBuild instance;

    private GameObject buildTower;
    public GameObject[] towerPrefabs;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.Log("teveel towerbuilds kut, mag er maar 1 zijn");
            return;
        }
        instance = this;
    }
    private void Start()
    {
        buildTower = towerPrefabs[0];
    }

    public GameObject GetBuildTower()
    {
        return buildTower;
    }
}
