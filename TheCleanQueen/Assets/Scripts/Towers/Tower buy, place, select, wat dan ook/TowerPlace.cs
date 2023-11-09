using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    private Color startColour;
    private Renderer ren;
    public GameObject myTower;

    public GameObject deleteKnop;
    public GameObject towerSprites;
    public Transform placeHere;
    public TowerSetManager towerSetManager;

    public int usedMoney = 0;
    private int moneyBack = 2;
    public bool towerPlaced;

    public IngameUI gameUI;
    public TowerBuild towerBuild;

    
    private void Start()
    {
        gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
        //hoverColour = Color.white;
        ren = GetComponentInChildren<MeshRenderer>();
        startColour = ren.material.GetColor("_FresnelshineColor");
        //ren.material.SetColor("_Color", Color.blue);
    }

    private void Update()
    {
        if(gameUI.topDown)
        {
            gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
        }
    }
     
    private void OnMouseDown()
    {
        if (gameUI.topDown)
        {
            towerSetManager.CloseAllTowerSets();
            deleteKnop.SetActive(false);

            if (towerPlaced)
            {
                Debug.Log("STAAT AL EEN TOWER AAAAAAAAAAAAAAAAH");
                deleteKnop.SetActive(true);
                towerSetManager.selectedTower = this.transform;
                return;
            }

            towerBuild.currentTowerPlace = this;
            towerSprites.SetActive(true);
        }
    }
    void OnMouseEnter()
    {
        if (gameUI.topDown)
        {
            ren.material.SetColor("_Color", Color.blue);
        }
    }
    private void OnMouseExit()
    {
        if (gameUI.topDown)
        {
            ren.material.color = startColour;
        }
    }

    //public void PlaceTower(int towerToBuild)
    //{
    //    Vector2 newTowerData = towerBuild.BuildThisTower(towerToBuild);
    //    buildTower = TowerBuild.instance.towerPrefabs[(int)newTowerData.x];
    //    towers = (GameObject)Instantiate(buildTower, transform.position, transform.rotation);
    //    Currency.money -= (int)newTowerData.y;
    //    towerSprites.SetActive(false);
    //}

    public void DeleteTower()
    {
        towerPlaced = false;
        //Destroy(GameObject.FindWithTag("Tower"));
        Destroy(myTower);
        Currency.money += usedMoney / moneyBack;
        usedMoney = 0;
        deleteKnop.SetActive(false);
       
    }

}
