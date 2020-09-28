using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorTrigger : MonoBehaviour
{
    public Rigidbody2D trapdoor; // set rigidbody var
    void OnTriggerEnter2D(Collider2D activator) {
        // set trapdoor in motion
        trapdoor.bodyType = RigidbodyType2D.Dynamic;
        // change indicating color to green
        trapdoor.GetComponent<SpriteRenderer>().color = new Color(0f, 255f, 0f, 1f);
    }
}
