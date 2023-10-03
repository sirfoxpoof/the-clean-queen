using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMenu : MonoBehaviour
{
    public GameObject towerButton;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TowerMenu"))
        {
            towerButton.SetActive(true);


        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("TowerMenu"))
        {
            towerButton.SetActive(false);

        }

    }
}
