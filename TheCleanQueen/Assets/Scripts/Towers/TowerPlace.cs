using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    private Color hoverColor, startColor;
    private Renderer ren;
    private GameObject towers;
    private Vector3 offset;

    public IngameUI gameUI;
    public TowerBuy koopjes;
    
    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        hoverColor = Color.magenta;
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
                Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAH");
                return;
            }

            if(koopjes.towOne ||koopjes.towTwo || koopjes.towThree || koopjes.towFour)
            {
                GameObject buildTower = TowerBuild.instance.GetBuildTower();
                towers = (GameObject)Instantiate(buildTower, transform.position, transform.rotation);

                koopjes.towOne = false;
                koopjes.towTwo = false;
                koopjes.towThree = false;
                koopjes.towFour = false;
            }
            else
            {
                Debug.Log("No tower selected!!!");
            }
            /*GameObject buildTower = TowerBuild.instance.GetBuildTower();
            towers = (GameObject)Instantiate(buildTower, transform.position, transform.rotation);

            koopjes.towOne = false;
            koopjes.towTwo = false;
            koopjes.towThree = false;
            koopjes.towFour = false;*/

            //gameUI.MainCamSwitch();
            //gameUI.towerMenu.SetActive(true);

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
