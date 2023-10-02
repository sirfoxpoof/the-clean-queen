using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemies", menuName = "Enemies/enemy", order = 1)]
public class SpawnScribtableObject : ScriptableObject
{
    public float speed;
    public int damage, health, coins;

}
