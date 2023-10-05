using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuy : MonoBehaviour
{
    public bool towOne, towTwo, towThree, towFour;

    public IngameUI gameUI;

    public void TowerOne()
    {
        towOne = true;
        towTwo = false;
        towThree = false;
        towFour = false;

        gameUI.TowerCamSwitch();
    }
    public void TowerTwo()
    {
        towOne = false;
        towTwo = true;
        towThree = false;
        towFour = false;

        gameUI.TowerCamSwitch();
    }
    public void TowerThree()
    {
        towOne = false;
        towTwo = false;
        towThree = true;
        towFour = false;

        gameUI.TowerCamSwitch();
    }
    public void TowerFOur()
    {
        towOne = false;
        towTwo = false;
        towThree = false;
        towFour = true;

        gameUI.TowerCamSwitch();
    }
}
