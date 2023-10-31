using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

public class Ani : MonoBehaviour
{
    public Animator falll;
   public bool fallen; 

    private void Start()
    {
        falll.Play("Walk");
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("Q");
            falll.Play("fall");
           
        }
        
        
       
    }
   
}
