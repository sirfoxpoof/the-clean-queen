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
                trash.position = pickupPoint.position;
                trash.GetComponent<Rigidbody>().useGravity = false;

                if (trash.CompareTag("Swing"))
                {
                    trash.GetComponentInChildren<Swing>().hierVuilnis = false;
                }
                else
                {
                    trash.GetComponentInParent<TowerExample>().vuilnisHier = false;
                }
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
