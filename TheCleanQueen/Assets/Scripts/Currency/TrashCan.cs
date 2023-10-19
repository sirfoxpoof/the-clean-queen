using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    public TrashPickup trashPickup;

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Trash" && trashPickup.pickedUp == false)
        {
            Destroy(trashPickup.trash.gameObject);
        }
    }
}
