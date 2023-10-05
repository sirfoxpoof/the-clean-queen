using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMenu : MonoBehaviour
{
    public GameObject towerButton;
    public bool bijTafel;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TowerMenu"))
        {
            towerButton.SetActive(true);
            bijTafel = true;

        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("TowerMenu"))
        {
            towerButton.SetActive(false);
            bijTafel = false;
        }

    }
}
