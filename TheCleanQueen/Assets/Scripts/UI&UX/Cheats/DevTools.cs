using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DevTools : MonoBehaviour
{
    
    int cheatMoney = 100;
    float skipTime = 1;
    public SpawnEnemy spawnEnemy;
    public void ExtraMoney(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Currency.money += cheatMoney;
        }
    }

    public void SkipTime(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            spawnEnemy.countdown = skipTime;
        }
    }
}
