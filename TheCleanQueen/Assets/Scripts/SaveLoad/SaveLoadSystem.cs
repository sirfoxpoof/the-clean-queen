using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadSystem : MonoBehaviour
{
    public GameObject unavailableLevel1, availableLevel1;

    public void Start()
    {
        if (PlayerPrefs.GetInt("levelsDone") >= 1)
        {
            unavailableLevel1.SetActive(false);
            availableLevel1.SetActive(true);
        }

        if (PlayerPrefs.GetInt("levelsDone") <= 1)
        {
            unavailableLevel1.SetActive(true);
            availableLevel1.SetActive(false);
        }
    }

    public void ResetProgress()
    {
        PlayerPrefs.SetInt("levelsDone", 0);
    }
}
