using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables
   [SerializeField] float speed;
   private float gravity = 9.8F;
   private Vector3 moveDirection = Vector3.zero;
 
    void Update() {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
   
        gameObject.transform.position = new Vector3 (transform.position.x + (h * speed), 
            transform.position.y + (0* speed), transform.position.z + (v * speed));
    }
}
    


