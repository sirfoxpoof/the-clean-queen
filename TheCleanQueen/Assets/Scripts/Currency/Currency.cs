using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public static int money;
    public TMP_Text moneyText, moneyTowerText;

    private void Awake()
    {
        money = 100;
    }
    private void Update()
    {
        moneyText.text = money.ToString();
        moneyTowerText.text = money.ToString();
    }
}
