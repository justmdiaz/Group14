﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

 
    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 10;
    int MinDist = 0;
 
 
    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }
 
     void FixedUpdate()
     {
         transform.LookAt(Player);
 
         if (Vector3.Distance(transform.position, Player.position) >= MinDist)
         {
 
             transform.position += transform.forward * MoveSpeed * Time.deltaTime;
 
 
 
             if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
             {
                 //Here Call any function U want Like Shoot at here or something
             }
 
         }
     }

}
