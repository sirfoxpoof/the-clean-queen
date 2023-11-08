using UnityEngine;

public class TowerSetManager : MonoBehaviour {
    public GameObject[] towerSets; 

    public void CloseAllTowerSets() {
        for (int i = 0; i < towerSets.Length; i++) {
            towerSets[i].SetActive(false);
        }
    }
}
