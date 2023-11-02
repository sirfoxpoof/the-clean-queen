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
    int kussenhealth;
    Enemies enemies;

    private void Awake()
    {
        enemies = gameObject.GetComponentInParent<Enemies>();
    }
    private void Start()
    {
        kussenhealth = enemies.enemyHealth;

        //falll.Play("Walk");

    }

    private void Update()
    {
        falll.SetFloat("Health", kussenhealth);
        //if (kussenhealth  < 5)
        //{

        //falll.Play("fall");

        //}



    }
   
}
