using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
   
    public PlayerInput playerInput;
    public GameObject SuccesTag, DeathGrab;
    public float speed = 7.0f;
    public float jumpForce = 5.0f;
    public bool isOnGround = true;
    //I(Xavi) added this public value so it might cause errors as it is from a different tutorial
    public Transform cam;
    //private float horizontalInput;
   // private float forwardInput;
    private Rigidbody playerRb;
    private float horInput = 0;
    private float verInput = 0;
    private Vector3 SpawnPosition;
    void Start()
    {
        SpawnPosition = gameObject.transform.position;
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player input
        // horizontalInput = Input.GetAxis("Horizontal");
        //forwardInput = Input.GetAxis("Vertical");
        Vector2 input = playerInput.actions["JoystickLook"].ReadValue<Vector2>();
        

        horInput = input.x;
        verInput = input.y;




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
        if (playerInput.actions["Jump"].IsPressed() && isOnGround)
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
        if (collision.gameObject.CompareTag("Death"))
        {

            gameObject.transform.position = SpawnPosition;
        }

       
      
      
       
       

        if(collision.gameObject.CompareTag("LevelSuccesTag")){
            DeathGrab.GetComponent<CountdownClock>().Death = true;
            SuccesTag.SetActive(true);
        }
    }

    //Here so the ball doesn't slow down when collecting the koopzegels -C 01-06
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Koopzegel")
        {
            Destroy(other.gameObject);
            KoopzegelScores.GetComponent<Scores>().KoopzegelScore = KoopzegelScores.GetComponent<Scores>().KoopzegelScore + 10;
        }
    }
}
