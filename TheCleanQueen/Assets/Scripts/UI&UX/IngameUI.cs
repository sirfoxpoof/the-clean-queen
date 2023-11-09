using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class IngameUI : MonoBehaviour
{
    public GameObject[] miniSprites;
    public GameObject towerMenu, towerButton, settingsPanel, winPanel, tutorial, moneyPanel, timePanel, quitMenu;
    public Camera mainCam, towerCam;
    public string sceneName;
    public bool towermenuOn = false, settingsAan = false, topDown = false, playTimer = false, tutorialDone = false;

    public TowerMenu towerMenuScript;
    public Movement moveScript;
    public SpawnEnemy spawnEnemy;


    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (sceneName == "BedroomLVL")
        {
            PlayerPrefs.SetInt("ShowTutorial", 1);
            towerMenu.SetActive(false);
            towerButton.SetActive(false);
            winPanel.SetActive(false);
            tutorial.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            moveScript.enabled = false;

            Time.timeScale = 0;
        }
        else
        {
            Tutorial();
        }
        
    }

    private void Update()
    {
        
        if (topDown)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
          
        }
         
        if(spawnEnemy.wavesClear)
        {
            winPanel.SetActive(true);
            PlayerPrefs.SetInt("levelsDone", 1);

            moveScript.enabled = false;
            spawnEnemy.countdown = 0;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }

    public void Tutorial()
    {
        Time.timeScale = 1;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        moveScript.enabled = true;
        playTimer = true;
        tutorialDone = true;

        tutorial.SetActive(false);
        moneyPanel.SetActive(true);
        timePanel.SetActive(true);
    }

    public void CloseTowerMenu(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if(towermenuOn == true)
            {
                CloseTower();
            }

        }    
    }

    public void CloseTower()
    {
        foreach (GameObject sprite in miniSprites)
        {
            sprite.SetActive(false);
        }

        moveScript.enabled = true;

        towerMenu.SetActive(false);

        towermenuOn = false;

        topDown = false;
        towerCam.enabled = false;
        mainCam.enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        
    }

    public void ShowTowerMenu(InputAction.CallbackContext context)
    {
        if (towerMenuScript.bijTafel)
        {
            if (context.performed)
            {
                mainCam.enabled = false;
                towerCam.enabled = true;
                moveScript.enabled = false;

                towerMenu.SetActive(true);
                towerButton.SetActive(false);

                towermenuOn = true;

                topDown = true;

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0;

            }

        }
        
    }

    public void DoSettingsMenu(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
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
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;

            settingsPanel.gameObject.SetActive(true);
            quitMenu.gameObject.SetActive(false);

            moveScript.enabled = false;

        }
        
    }

    public void SettingsMenuOff()
    {
        if(tutorialDone == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;

            settingsPanel.gameObject.SetActive(false);

            moveScript.enabled = false;
        }

        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1;

            settingsPanel.gameObject.SetActive(false);

            moveScript.enabled = true;
        }

    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}


