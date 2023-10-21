using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TrashPickup : MonoBehaviour
{
    public Transform pickupPoint, trash;
    public Camera camCam;
    private RaycastHit hit;

    public bool pickedUp;

    private TowerExample towerExample;
    private Swing swing;


    public void PickUpTrash(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if(!pickedUp)
            {
                if (Physics.Raycast(transform.position, transform.forward, out hit, 5f))
                {
                    if (hit.transform.tag == "Trash")
                    {
                        trash = hit.transform;

                        pickedUp = true;
                        //towerExample = gameObject.GetComponent<TowerExample>();
                        //towerExample = trash.GetComponentInChildren<TowerExample>();
                    }
                }
            }
            else if (pickedUp)
            {
                pickedUp = false;
            }
        }
    }

    private void Update()
    {
        if (towerExample == null || swing == null)
        {
            return;
        }

    }

    private void FixedUpdate()
    {

        if(trash != null)
        {
            if (pickedUp)
            {
                //towerExample.vuilnisHier = false;
                trash.position = pickupPoint.position;
                trash.GetComponent<Rigidbody>().useGravity = false;

                trash.GetComponentInChildren<Swing>().hierVuilnis = false;
                trash.GetComponentInParent<TowerExample>().vuilnisHier = false;
                towerExample = null;
            }
            else
            {
                trash.GetComponent<Rigidbody>().useGravity = true;
            }
        }
        else
        {
            return;
        }
    }
}
