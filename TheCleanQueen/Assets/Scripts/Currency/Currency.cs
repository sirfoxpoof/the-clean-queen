using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public static int towerMoney;
    public TMP_Text moneyText;

    private void Update()
    {
        moneyText.text = towerMoney.ToString();
    }
}
