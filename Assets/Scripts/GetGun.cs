using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGun : MonoBehaviour
{
    public GameObject p;
    public GameObject textStart;
    public GameObject textEneymy;
    public GameObject textDoor;
    // get gun after entering trigger
    void OnTriggerEnter2D(Collider2D activator) {
        // activate gun in player
        p.SetActive(true);
        // text manipulation
        textStart.SetActive(false);
        textEneymy.SetActive(false);
        textDoor.SetActive(true);
        // destroy gun sprite
        Destroy(gameObject);
    }
    // sprite movement
    void Update() {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, .4f), transform.position.z);
    }
}
