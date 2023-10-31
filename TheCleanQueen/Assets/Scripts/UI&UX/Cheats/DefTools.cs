using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DefTools : MonoBehaviour
{
    int cheatMoney = 100;

    public void ExtraMOney(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Currency.money += cheatMoney;
        }
    }
}
