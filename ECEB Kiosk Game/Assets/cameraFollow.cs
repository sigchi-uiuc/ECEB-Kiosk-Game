using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform cameraTransform;
    public Transform playerTransform;
    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        cameraTransform.position = playerTransform.position + offset;
        //cameraTransform.rotation = playerTransform.rotation;

    }
}
