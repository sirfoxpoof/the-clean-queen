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

                        GrabTrashBag();
                    }
                }
            }
            else if (pickedUp)
            {
                LetGoOfTrashBag();
            }
        }
    }

    void GrabTrashBag()
    {
        pickedUp = true;
        trash.transform.SetParent(pickupPoint, false);
        trash.transform.position = Vector3.zero;
        trash.GetComponent<Rigidbody>().useGravity = false;
        trash.GetComponent<Trash>().RemoveFromTower();
    }

    void LetGoOfTrashBag()
    {
        pickedUp = false;
        trash.GetComponent<Rigidbody>().useGravity = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trashcan")
        {
            Currency.money += trash.GetComponent<Trash>().trashMoney;
            Destroy(gameObject);
        }
    }
}
