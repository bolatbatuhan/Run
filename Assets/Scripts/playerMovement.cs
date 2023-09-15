using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    
    private float rotationX;

    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);

         rotationX = Input.GetAxis("Horizontal");
       
         transform.Translate(Vector3.right * rotationX * sidewaysForce * Time.deltaTime);

        if(rb.position.y < -1)
        {
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
