using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedTrigger : MonoBehaviour
{
    public PlayerMovement player; // assign

    // every frame when obj in trigger
    void OnTriggerStay2D(Collider2D activator) {
        player.isGrounded = true;
        player.canDoubleJump = false;
    }
    // first frame when obj leave trigger
    void OnTriggerExit2D(Collider2D activator) {
        player.isGrounded = false;
        player.canDoubleJump = true;
    }
}
