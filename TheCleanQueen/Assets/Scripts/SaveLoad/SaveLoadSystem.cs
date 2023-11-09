using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject unavailableLevel1, availableLevel1;
    public void Start()
    {
        if (PlayerPrefs.GetInt("levelsDone") >= 1)
        {
            unavailableLevel1.SetActive(false);
            availableLevel1.SetActive(true);
        }
    }
}
