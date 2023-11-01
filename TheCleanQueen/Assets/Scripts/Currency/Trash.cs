using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public TowerExample towerExample;
    public int trashMoney = 0;

    private void Awake()
    {
        towerExample = GetComponentInParent<TowerExample>();
        trashMoney = 0;
    }
}
