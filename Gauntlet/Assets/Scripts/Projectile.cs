using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody.AddForce(direction * force);
    }

    void OnCollisionEnter(Collision collision)
    {
        
    }
}
