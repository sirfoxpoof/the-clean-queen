using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    private Color hoverColor, startColor;
    private Renderer ren;
    private GameObject towers;
    //public Transform[] towerVakjes;

    public IngameUI gameUI;

  
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

            GameObject buildTower = TowerBuild.instance.GetBuildTower();
            towers = (GameObject)Instantiate(buildTower, transform.position, transform.rotation);
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
