using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectileEmitter;
    public GameObject prefabToSpawn;
    public float projectileSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("space"))
       {
           GameObject tempProjectileHandler;
           tempProjectileHandler = Instantiate(prefabToSpawn, projectileEmitter.transform.position, projectileEmitter.transform.rotation) as GameObject;

            tempProjectileHandler.transform.Rotate(Vector3.left * 90);

            Rigidbody tempRigidbody;
            tempRigidbody = tempProjectileHandler.GetComponent<Rigidbody>();

            tempRigidbody.AddForce(transform.forward * projectileSpeed);

            Destroy(tempProjectileHandler, 3f);
       } 
    }

    
}

    
