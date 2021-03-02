using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    //Player Vector 3
    public Vector3 player;
    //Player Speed
    public float playerSpeed;
    //Player rigid body
    private Rigidbody2D rb;
    //player input
    private float moveInput;
    //jump power
    public float jumpPower;
    //variables to check if player is on the ground
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
   
    void Start()
    {
       //gets rigid body of player
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        //if input along the horizontal access is happening, the input is set to the player multiplied by player speed
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * playerSpeed, rb.velocity.y);
     
        //if jump button is pressed and is grounded the player jumps 
       
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpPower; 
        }
        



    }
    void FixedUpdate()
    {
       

        //makes a circle which is used to find it player is on ground
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        //updates the position of the player to make it move
       
        

    }
}
