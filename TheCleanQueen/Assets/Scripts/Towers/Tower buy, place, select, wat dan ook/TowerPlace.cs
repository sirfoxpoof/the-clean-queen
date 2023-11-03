using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    private Color startColour;
    private Renderer ren;

    public GameObject deleteKnop;

    public GameObject towerSprites;
    public Vector3 posTowerPlace;
    public IngameUI gameUI;
    public TowerBuild towerBuild;

    bool towerPlaced;
    
    private void Start()
    {
        gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
        //hoverColour = Color.white;
        ren = GetComponentInChildren<MeshRenderer>();
        //startColour = ren.material.GetColor("_ShimmerColor");
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

            if (towerBuild.currentTowerPlace != null)
            {
                Debug.Log("STAAT AL EEN TOWER AAAAAAAAAAAAAAAAH");
                //deleteKnop.SetActive(true);
                return;
            }

            towerBuild.currentTowerPlace = this;
            towerSprites.SetActive(true);
            Debug.Log(towerBuild.currentTowerPlace);
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

    /*public void DeleteTower()
    {
        Destroy(buildTower.gameObject);
        deleteKnop.SetActive(false);
    }*/

}
