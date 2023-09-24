using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class IngameUI : MonoBehaviour
{
    public GameObject towerMenu, camSwitchButton, towerButton;
    public Movement moveScript;
    public Camera mainCam, towerCam;

    private void Start()
    {
        towerMenu.SetActive(false);
        camSwitchButton.SetActive(false);
        towerButton.SetActive(false);
    }

    public void CloseTowerMenu(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            CloseTower();

        }
            
    }

    public void CloseTower()
    {
        moveScript.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        towerMenu.SetActive(false);
    }

    public void ShowTowerMenu(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("niet zo irritant doen <3");
            moveScript.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
            towerMenu.SetActive(true);

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TowerMenu"))
        {
            towerButton.SetActive(true);

        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("TowerMenu"))
        {
            towerButton.SetActive(false);

        }

    }


    public void TowerCamSwitch()
    {
        mainCam.enabled = false;
        towerCam.enabled = true;
        towerMenu.SetActive(false);
        camSwitchButton.SetActive(true);
    }

    public void MainCamSwitch()
    {
        mainCam.enabled = true;
        towerCam.enabled = false;
        towerMenu.SetActive(true);
        camSwitchButton.SetActive(false);
    }

}


