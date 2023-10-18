using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    private Color startColour;
    private Renderer ren;
    private GameObject towers;

    public IngameUI gameUI;
    public TowerBuild towerBuild;
    
    private void Start()
    {

        gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
        //hoverColour = Color.white;
        ren = GetComponentInChildren<MeshRenderer>();
        startColour = ren.material.GetColor("_Color");
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
                return;
            }

            if(Currency.towerMoney >= towerBuild.neededMoney)
            {
                if (towerBuild.towOne || towerBuild.towTwo || towerBuild.towThree || towerBuild.towFour)
                {
                    GameObject buildTower = TowerBuild.instance.GetBuildTower();
                    towers = (GameObject)Instantiate(buildTower, transform.position, transform.rotation);

                    Currency.towerMoney -= towerBuild.neededMoney;

                    towerBuild.towOne = false;
                    towerBuild.towTwo = false;
                    towerBuild.towThree = false;
                    towerBuild.towFour = false;
                }
                else
                {
                    Debug.Log("No tower selected!!!");
                }
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
            // ren.material.color = hoverColour;
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

}
