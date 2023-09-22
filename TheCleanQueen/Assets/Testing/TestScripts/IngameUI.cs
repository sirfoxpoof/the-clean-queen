using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class IngameUI : MonoBehaviour
{

    public bool settingsAan = false;
    public GameObject settingsPNG, settingsMenu;

    

    public void DoSettingsMenu(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            
            if (!settingsAan)
            {
                SettingsMenuOn();
                
            }

            else
            {
                SettingsMenuOff();
            }
        }
    }

    public void SettingsMenuOn()
    {
        settingsAan = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        settingsPNG.gameObject.SetActive(true);
        settingsMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void SettingsMenuOff()
    {
        settingsAan = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        settingsPNG.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(false);
       Time.timeScale = 1;
    }
}

