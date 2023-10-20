using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public TowerExample towerExample;
    private void Awake()
    {
        towerExample = GetComponentInParent<TowerExample>();
    }
}
