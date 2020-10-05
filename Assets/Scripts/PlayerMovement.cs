using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D myRb;
    float inputHori;
    public bool isJumping;
    bool facingLeft;
    bool facingRight;
    public bool isGrounded; // set by GroundedTigger.cs
    public bool canDoubleJump;
    public float moveSpeed = 10f;
    public float jumpSpeed = 1f;

    void Start()
    {
        facingLeft = false;
        facingRight = true;
        myRb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        // movement horizontal with virtual input axis
        inputHori = Input.GetAxis("Horizontal"); // return val from -1 to 1
        
        // change player direction (facing)
        if (inputHori < 0 && !facingLeft) {
            facingLeft = true;
            facingRight = false;
            transform.Rotate(0f, 180f, 0f);
        }
        if (inputHori > 0 && !facingRight) {
            facingRight = true;
            facingLeft = false;
            transform.Rotate(0f, 180f, 0f);
        }

        // jumping
        if (Input.GetButtonDown("Jump") && isGrounded){
            isJumping = true;
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetButtonDown("Jump") && canDoubleJump) {
            isJumping = true;
            canDoubleJump = false;
            GetComponent<AudioSource>().Play();
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