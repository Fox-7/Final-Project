using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Create a variable called 'rb' that will represent the rigid body of this object.
    private Rigidbody rb;

    // Create variables for camera movement speed and smoothness
    public Transform cam;
    public float speed = 6f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;


    // How much force when jumping
    public float jumpForce = 1f;
    // Allows the functions to determine whether player is grounded
    private bool onGround;

    // Variables for audio clips
    private AudioSource source;
    private AudioClip firstAudioClip;
    private AudioClip secondAudioClip;

    public Animator animator;

    // Create a public variable for the cameraTarget object
    public GameObject cameraTarget;

    // Creates a public variable that will be used to set the movement intensity 
    public float movementIntensity;
    public float rollSpeed;
    public float walkSpeed;


    // Keep the collider object
    Collider coll;

    // Method for picking up collectibles
    void OnCollisionEnter(Collision collision)
    {

        // if player collides with object tagged "warp"
        if (collision.collider.tag == "warp")
        {
            // travel to next level
            Application.LoadLevel("Loading_2");
        }

        if (collision.collider.tag == "warp2")
        {
            // travel to next level
            Application.LoadLevel("Loading_3");
        }

        if (collision.collider.tag == "warp3")
        {
            // travel to next level
            Application.LoadLevel("Ending");
        }

        // Checks if collider is tagged "ground"
        if (collision.gameObject.CompareTag("ground"))
        {
            // if the collider is tagged "ground", sets onGround boolean to true
            onGround = true;
        }

        // Checks if collider is tagged "water"
        if (collision.gameObject.CompareTag("water"))
        {
            // if the collider is tagged "water", game over
            Application.LoadLevel("Game Over");
        }
    }

    void Start()
    {
        // make  rb variable equal the rigid body component
        rb = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
        coll = GetComponent<Collider>();
        onGround = true;

    }

    void Update()
    {
        //Establish some directions based on the cameraTarget object's orientation 
        var ForwardDirection = cameraTarget.transform.forward;
        var RightDirection = cameraTarget.transform.right;

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        // Move Forwards
        if (Input.GetKey(KeyCode.W))
        {

            rb.velocity = ForwardDirection * movementIntensity;
            
        }

        void OnCollisionStay()
        {
            // isGrounded = true;
        }

        // Move Backwards
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = -ForwardDirection * movementIntensity;

        }

        // Move Rightwards
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = RightDirection * movementIntensity;

        }

        // Move Rotation Rightwards
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 3, 0);

        }

        // Move Leftwards
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -RightDirection * movementIntensity;

        }

        // Move Rotation Leftwards
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -3, 0);

        }

        // Roll animation
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("Start");
            rb.constraints = RigidbodyConstraints.None;
            movementIntensity = rollSpeed;

        }

        // Unroll animation
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("Revert");
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            movementIntensity = walkSpeed;

        }


        // Jump
        if (Input.GetButton("Jump") && onGround == true)
        {
            //adds force to player on the y axis by using the flaot set for the variable jumpForce. 
            rb.velocity = new Vector3(0f, jumpForce, 0f);
            //says the player is no longer on the ground
            onGround = false;
            //plays jump sound effect
            source.Play();


        }
    }
}