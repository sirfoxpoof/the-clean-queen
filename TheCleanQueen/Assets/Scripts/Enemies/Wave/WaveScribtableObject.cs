using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Wave", menuName = "Waves/wave", order = 1)]

public class WaveScribtableObject : ScriptableObject
{
    public Wave[] waves;
}
