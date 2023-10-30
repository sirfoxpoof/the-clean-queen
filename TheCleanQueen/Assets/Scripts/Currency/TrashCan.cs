using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class TrashCan : MonoBehaviour
{
    public TrashPickup trashPickup;
    private Trash trashh;

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Trash" && trashPickup.pickedUp == false)
        {
            trashh = trashPickup.trash.gameObject.GetComponent<Trash>();
            Destroy(trashPickup.trash.gameObject);
            Currency.money += trashh.trashMoney;
        }
    }
}
