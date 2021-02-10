using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class CameraScript : MonoBehaviour {

    Rigidbody Rigidbody;
    [SerializeField] float turnSpeed = 4.0f;
    [SerializeField] Transform player;
    private float angleBetween = 0.0f;
    [SerializeField] Transform target;
    private Vector3 offset;
 
    void Start () {
        Rigidbody = GetComponent<Rigidbody>();
        offset = new Vector3(player.position.x, player.position.y + 3.0F , player.position.z + 7.0f);
    }
 
    void Update()
    {
        Vector3 targetDir = target.position - transform.position;
        angleBetween = Vector3.Angle(transform.forward, targetDir);
    }
    
    void LateUpdate()
    {
        offset = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        transform.position = player.position + offset; 
        transform.LookAt(player.position);
        
    }
    
}


