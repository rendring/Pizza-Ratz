using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Xml.Schema;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject SuccesTag, DeathGrab;

    public float speed = 5.0f;
    public float jumpForce = 5.0f;
    public bool isOnGround = true;
    //I(Xavi) added this public value so it might cause errors as it is from a different tutorial
    public Transform cam;
    //private float horizontalInput;
   // private float forwardInput;
    private Rigidbody playerRb;
    private float horInput = 0;
    private float verInput = 0;
    CharacterController controller;
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
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");
       


        //Moving the player

        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        //this is what I(Xavi) added so it is from a different tutorial and might cause errors
        //cam directions
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camRight.y = 0;

        //creating relate cam direction
        Vector3 forwardRelative = verInput * camForward;
        Vector3 rightRelative = horInput * camRight;

        Vector3 moveDir = forwardRelative + rightRelative;

        playerRb.AddForce(new Vector3(moveDir.x, 0f, moveDir.z) * speed);
        //boing boing
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

    }
    private void OnCollisionEnter(Collision collision)       
{
        if (collision.gameObject.CompareTag("LevelSuccesTag"))
        {
            DeathGrab.GetComponent<CountdownClock>().Death = true;
            SuccesTag.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

 
}
