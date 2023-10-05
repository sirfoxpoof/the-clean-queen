using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class IngameUI : MonoBehaviour
{
    public GameObject towerMenu, camSwitchButton, towerButton, settingsPanel, tutorialText, plafond;
    public Movement moveScript;
    public Camera mainCam, towerCam;
    public string sceneName;
    public bool towermenuOn = false, settingsAan = false, topDown = false;

    

    public void Start()
    {
        towerMenu.SetActive(false);
        camSwitchButton.SetActive(false);
        towerButton.SetActive(false);
        tutorialText.SetActive(true);
       

        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (sceneName == "BedroomLVL")
        {
            PlayerPrefs.SetInt("ShowTutorial", 1);
        }

        Debug.Log(PlayerPrefs.GetInt("ShowTutorial"));


    }

    public void Update()
    {
        if (sceneName == "BedroomLVL")
        {
            if (PlayerPrefs.GetInt("ShowTutorial") == 0)
            {
                tutorialText.SetActive(false);
            }
        }

        if (topDown)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
          
        }
       

    }

    public void CloseTowerMenu(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (towermenuOn == true)
            {
                CloseTower();
            }
        }    
    }

    public void CloseTower()
    {
        moveScript.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        towerMenu.SetActive(false);
        towermenuOn = false;
    }

    public void ShowTowerMenu(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
                moveScript.enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0;
                towerMenu.SetActive(true);
                towerButton.SetActive(false);
                towermenuOn = true;
                PlayerPrefs.SetInt("ShowTutorial", 0);
        }
    }

    


    public void TowerCamSwitch()
    {
        mainCam.enabled = false;
        towerCam.enabled = true;
        towerMenu.SetActive(false);
        camSwitchButton.SetActive(true);
        topDown = true;
        plafond.SetActive(false);
    }

    public void MainCamSwitch()
    {
        mainCam.enabled = true;
        towerCam.enabled = false;
        towerMenu.SetActive(true);
        camSwitchButton.SetActive(false);
        topDown = false;
        plafond.SetActive(true);
    }

    public void DoSettingsMenu(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("WERK NOU MEE JEZUS");

            if (!settingsAan)
            {
                SettingsMenuOn();
            }
            else
            {
                SettingsMenuOff();

            }
            settingsAan = !settingsAan;
        }
    }

    public void DoSettingsMenuButton()
    {
        Debug.Log("WERK NOU MEE JEZUS");

        if (!settingsAan)
        {
            SettingsMenuOn();
        }
        else
        {
            SettingsMenuOff();

        }
        settingsAan = !settingsAan;
    }

    public void SettingsMenuOn()
    {
        if(towermenuOn == true)
        {
            CloseTower();
            settingsAan = !settingsAan;
        }
        else
        {
            Debug.Log("hoereding");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            settingsPanel.gameObject.SetActive(true);
            Time.timeScale = 0;
            moveScript.enabled = false;
            tutorialText.SetActive(false);
        }
        
    }

    public void SettingsMenuOff()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        settingsPanel.gameObject.SetActive(false);
        Time.timeScale = 1;
        moveScript.enabled = true;
        tutorialText.SetActive(true);
    }
}


