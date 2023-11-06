using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class TrashPickup : MonoBehaviour
{
    public Transform trash;
    private RaycastHit hit;

    public int storedMoney, trashBags, maxTrash = 5;

    public bool pickedUp;

    //UI
    public TMP_Text trashPanel;

    
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
                        Debug.Log("TRASHHHH");
                        GrabTrashBag();
                    }
                    else if (hit.transform.tag == "Trashcan")
                    {
                        Debug.Log("TRASHHHHHCANNNNNN");
                        Currency.money += storedMoney;
                        storedMoney = 0;
                        trashBags = 0;
                        trashPanel.text = trashBags.ToString();
                    }
                }
            }
        }
    }

    void GrabTrashBag()
    {

        if(trashBags > maxTrash)
        {
            Debug.Log("Too many trashbags!!!");
            return;
        }
        else if(trashBags <= maxTrash) 
        { 
           storedMoney += trash.gameObject.GetComponent<Trash>().trashMoney;
           Destroy(trash.gameObject);
           trashBags++;
           trashPanel.text = trashBags.ToString();
           trash.GetComponent<Trash>().RemoveFromTower();
        }

        /*
        pickedUp = true;
        trash.transform.SetParent(pickupPoint, false);
        trash.transform.position = Vector3.zero;
        trash.GetComponent<Rigidbody>().useGravity = false;
        trash.GetComponent<Trash>().RemoveFromTower();*/
    }

   /* void LetGoOfTrashBag()
    {
        pickedUp = false;
        trash.GetComponent<Rigidbody>().useGravity = true;
    }*/

   /* private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trashcan")
        {
            Currency.money += trash.GetComponent<Trash>().trashMoney;
            trashBags = 0;
            trashPanel.text = trashBags.ToString();
            //Destroy(trash.gameObject);
        }
    }*/
}
