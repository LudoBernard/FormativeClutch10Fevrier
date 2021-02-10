using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Transform camPivot;
    float heading = 0;
    [SerializeField] Transform cam;
    [SerializeField] float mouseSensitivity;
    [SerializeField] private float speed;
    Vector2 input;
    void Update()

    {

        heading += Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;

        camPivot.rotation = Quaternion.Euler(0, heading, 0);
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 1);

        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;

        camF.y = 0;
        camR.y = 0;
        camF = camF.normalized;
        camR = camR.normalized;

        //transform.position += new Vector3(input.x,0,input.y) *Time.deltaTime”S5;

        transform.position += (camF * input.y + camR * input.x) * Time.deltaTime * speed;

    }

}
    


