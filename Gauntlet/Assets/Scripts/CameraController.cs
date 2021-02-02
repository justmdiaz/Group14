using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform targetObject;
    private Vector3 initalOffset;
    private Vector3 cameraPosition;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        cameraPosition = targetObject.position + initalOffset;
        transform.position = cameraPosition;
    }
}
