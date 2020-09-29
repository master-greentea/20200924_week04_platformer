using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public Rigidbody2D textEnd;
    void OnTriggerEnter2D(Collider2D activator) {
        textEnd.bodyType = RigidbodyType2D.Dynamic;
    }
}
