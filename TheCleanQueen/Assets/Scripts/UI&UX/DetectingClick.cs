using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DetectingClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    private GameObject popup;
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        popup.SetActive(false);
        print("wazaa");

    }

    
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        //heheheheheh
    }
}
