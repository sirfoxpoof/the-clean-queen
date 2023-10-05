using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    private Color hoverColor, startColor;
    private Renderer ren;
    private GameObject[] towers;
    //public Transform[] towerVakjes;

    public IngameUI gameUI;

    private bool towOne, towTwo, towThree, towFour;
  
    private void Start()
    {
        hoverColor = Color.magenta;
        ren = GetComponent<Renderer>();
        startColor = ren.material.color;
    }

    private void OnMouseDown()
    {
        if (gameUI.topDown)
        {
            if (towers != null)
            {
                Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAH");
                return;
            }

            if (towOne)
            {
                GameObject buildTower = TowerBuild.instance.GetBuildTower();
                towers[0] = (GameObject)Instantiate(buildTower, transform.position, transform.rotation);
            }
            if (towTwo)
            {
                GameObject buildTower = TowerBuild.instance.GetBuildTower();
                towers[1] = (GameObject)Instantiate(buildTower, transform.position, transform.rotation);
            }
            if (towThree)
            {
                GameObject buildTower = TowerBuild.instance.GetBuildTower();
                towers[2] = (GameObject)Instantiate(buildTower, transform.position, transform.rotation);
            }
            if (towFour)
            {
                GameObject buildTower = TowerBuild.instance.GetBuildTower();
                towers[3] = (GameObject)Instantiate(buildTower, transform.position, transform.rotation);
            }

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

    public void TowerOne()
    {
        towOne = true;
    }
    public void TowerTwo()
    {
        towTwo = true;
    }
    public void TowerThree()
    {
        towThree = true;    
    }
    public void TowerFOur()
    {
        towFour = true;
    }

}
