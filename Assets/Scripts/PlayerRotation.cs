using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    
    private float speedH = 2.0f;
    private float speedV = 2.0f;
 
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    public float maxDegreesDelta = 15f;
 
    Transform cameraT;
    CharacterController controller;
 
    private void Start()
    {
        cameraT = GetComponent<Transform>();
        controller = GetComponent<CharacterController>();
 
    }
 
    void Update()
    {
        Vector3 cameraDirection = new Vector3(cameraT.forward.x, 0f, cameraT.forward.z);
        Vector3 playerDirection = new Vector3(controller.velocity.x, 0f, controller.velocity.z);
 
        if (Vector3.Angle(cameraDirection, playerDirection) > 15f)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, transform.rotation, 15f);
        }
 
    }
    
}
