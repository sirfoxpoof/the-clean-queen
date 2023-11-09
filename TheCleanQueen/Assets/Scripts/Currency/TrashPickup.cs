using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class TrashPickup : MonoBehaviour
{
    public Transform pickupPoint, trash;
    public Camera camCam;
    public AudioSource coinAudio;
    public GameObject tooMuchTrash;
    public bool panelActive;
    private RaycastHit hit;

    public int storedMoney, trashBags;
    private int maxTrash = 4;

    public bool pickedUp;

    public TMP_Text trashPanel;

    public LayerMask pickupslayer;

    public void PickUpTrash(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if(!pickedUp)
            {
                if (Physics.Raycast(transform.position, transform.forward, out hit, 5f, pickupslayer))
                {
                    if (hit.transform.tag == "Trash")
                    {
                        trash = hit.transform;
                        GrabTrashBag();
                    }
                    else if (hit.transform.tag == "Trashcan")
                    {
                        Currency.money += storedMoney;
                        storedMoney = 0;
                        trashBags = 0;
                        trashPanel.text = trashBags.ToString();
                        coinAudio.Play();

                    }
                }
            }
        }
    }

    void GrabTrashBag()
    {
        if (trashBags > maxTrash)
        {
            if(panelActive == false)
            {
                tooMuchTrash.SetActive(true);
                panelActive = true;
                StartCoroutine(TooMuchTrashNotif());
                return;
            }
            
        }
        else if (trashBags <= maxTrash)
        {
            trash.GetComponent<Trash>().RemoveFromTower();
            storedMoney += trash.gameObject.GetComponent<Trash>().trashMoney;
            Destroy(trash.gameObject);
            trashBags++;
            trashPanel.text = trashBags.ToString();
        }

        IEnumerator TooMuchTrashNotif()
        {
            yield return new WaitForSeconds(3);
            tooMuchTrash.SetActive(false);
            panelActive = false;
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
            Destroy(trash.gameObject);
        }
    }*/
}
