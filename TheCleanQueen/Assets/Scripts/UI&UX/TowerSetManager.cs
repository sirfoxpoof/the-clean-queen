using UnityEngine;

public class TowerSetManager : MonoBehaviour {
    public GameObject[] towerSets;
    public Transform selectedTower;

    public void CloseAllTowerSets() {
        for (int i = 0; i < towerSets.Length; i++) {
            towerSets[i].SetActive(false);
        }
    }

    public void DestroyThatFucker ()
    {
        selectedTower.GetComponent<TowerPlace>().DeleteTower();
    }
}
