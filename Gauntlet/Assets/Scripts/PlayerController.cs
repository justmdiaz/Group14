﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;

    float moveHorizontal;
    float moveVertical;
    public float speed = 6f;
    public float projectileSpeed = 1000f;
    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Movement
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if(moveHorizontal != 0 || moveVertical != 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);
        }

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
        //

        //Launching Projectiles
         if(Input.GetKeyDown("space"))
         {
             LaunchProjectile();
         }

    }

    void LaunchProjectile()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, transform.position, Quaternion.identity) as GameObject;
        Rigidbody projectileObjectRigidbody = projectileObject.GetComponent<Rigidbody>();
        projectileObjectRigidbody.AddForce(Vector3.forward * projectileSpeed);
    }
}
