using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    private Color startColour;
    private Renderer ren;
    private GameObject towers, buildTower;

    public GameObject deleteKnop;

    public GameObject towerSprites;
    public Vector3 posTowerPlace;
    public IngameUI gameUI;
    public TowerBuild towerBuild;
    
    private void Start()
    {
        gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
        //hoverColour = Color.white;
        ren = GetComponentInChildren<MeshRenderer>();
        startColour = ren.material.GetColor("_ShimmerColor");
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
            if (towers != null)
            {
                Debug.Log("STAAT AL EEN TOWER AAAAAAAAAAAAAAAAH");
               //deleteKnop.SetActive(true);
                return;
            }

            towerSprites.SetActive(true);

            if(Currency.money >= towerBuild.neededMoney)
            {
                
            }
            else
            {
                Debug.Log("Not enough money!!!!");
            }
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

    public void PlaceTower()
    {
        if (towerBuild.towOne || towerBuild.towTwo || towerBuild.towThree || towerBuild.towFour)
        {
            buildTower = TowerBuild.instance.GetBuildTower();

            Debug.Log(towerBuild.towOne);
            Debug.Log(towerBuild.towTwo);
            Debug.Log(towerBuild.towThree);
            Debug.Log(towerBuild.towFour);


            towers = (GameObject)Instantiate(buildTower, posTowerPlace, transform.rotation);


            Currency.money -= towerBuild.neededMoney;

            towerSprites.SetActive(false);

            towerBuild.towOne = false;
            towerBuild.towTwo = false;
            towerBuild.towThree = false;
            towerBuild.towFour = false;
        }
    }

    public void GetTransformTowerPlace()
    {
        posTowerPlace = transform.position;


    }

    /*public void DeleteTower()
    {
        Destroy(buildTower.gameObject);
        deleteKnop.SetActive(false);
    }*/

}
