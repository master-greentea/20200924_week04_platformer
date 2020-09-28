using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D myRb;
    float inputHori;
    bool isJumping;
    public bool isGrounded; // set by GroundedTigger.cs
    public bool canDoubleJump;
    public float moveSpeed = 10f;
    public float jumpSpeed = 1f;

    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        // movement horizontal with virtual input axis
        inputHori = Input.GetAxis("Horizontal"); // return val from -1 to 1
        
        // jumping
        if (Input.GetButtonDown("Jump") && isGrounded){
            isJumping = true;
        }
        if (Input.GetButtonDown("Jump") && canDoubleJump) {
            isJumping = true;
            canDoubleJump = false;
        }
    }

    // happens every physics frame, fixed timestep
    void FixedUpdate() {
        myRb.velocity = new Vector2(inputHori * moveSpeed, myRb.velocity.y);
        
        if (isJumping) {
            myRb.velocity = new Vector2(myRb.velocity.x, jumpSpeed);
            isJumping = false;
        }
    }
}