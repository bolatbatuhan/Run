using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    

    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        float rotationX = Input.GetAxis("Horizontal") * sidewaysForce * Time.deltaTime;
       
        transform.Translate(rotationX, 0, 0,Space.World);
    }
}
