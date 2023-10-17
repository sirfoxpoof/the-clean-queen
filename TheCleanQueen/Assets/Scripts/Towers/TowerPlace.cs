using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    private Color hoverColor, startColor;
    private Renderer ren;
    private GameObject towers;

    public IngameUI gameUI;
    public TowerBuild towerBuild;
    
    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        hoverColor = Color.white;
        ren = GetComponent<Renderer>();
        startColor = ren.material.color;
    }

    private void Update()
    {
        if(gameUI.topDown)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
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

            /*if(towerBuild.towOne ||towerBuild.towTwo || towerBuild.towThree || towerBuild.towFour)
            {
                GameObject buildTower = TowerBuild.instance.GetBuildTower();
                towers = (GameObject)Instantiate(buildTower, transform.position, transform.rotation);

                towerBuild.towOne = false;
                towerBuild.towTwo = false;
                towerBuild.towThree = false;
                towerBuild.towFour = false;
            }
            else
            {
                Debug.Log("No tower selected!!!");
            }*/
        }
    }
    void OnMouseEnter()
    {
        if (gameUI.topDown)
        {
          ren.material.color = hoverColor;
        }
    }
    private void OnMouseExit()
    {
        if (gameUI.topDown)
        {
            ren.material.color = startColor;
        }
    }

}
