using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables
   [SerializeField] private float speed_;
 
    void FixedUpdate() {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
   
        gameObject.transform.position = new Vector3 (transform.position.x + (h * speed_ * Time.fixedDeltaTime), 
            transform.position.y + (0* speed_), transform.position.z + (v * speed_ * Time.fixedDeltaTime));
    }
}
    


