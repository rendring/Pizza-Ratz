using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 5.0f;
    public bool isOnGround = true;
    //private float horizontalInput;
   // private float forwardInput;
    private Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player input
        // horizontalInput = Input.GetAxis("Horizontal");
        //forwardInput = Input.GetAxis("Vertical");
        if(Input.GetAxis("Horizontal") > 0)
        {
            playerRb.AddForce(Vector3.right * speed);
        }

    else if(Input.GetAxis("Horizontal") < 0)
        {
            playerRb.AddForce(-Vector3.right * speed);
        }

        if(Input.GetAxis("Vertical") > 0)
        {
            playerRb.AddForce(Vector3.forward * speed);
        }

    else if (Input.GetAxis("Vertical") < 0)
        {
            playerRb.AddForce(-Vector3.forward* speed);
        }
        //Moving the player

        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);



        //boing boing
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
