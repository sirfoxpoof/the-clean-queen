using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public static int money = 1000;
    public TMP_Text moneyText;

    private void Update()
    {
        moneyText.text = money.ToString();
    }
}
