using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public PlayerMovement player;
    public Rigidbody2D enemy;
    void Start()
    {
        Rigidbody2D newEnemy = Instantiate(enemy, transform.position, Quaternion.identity);
    }
    void Update()
    {
        if (player.isJumping){
            Rigidbody2D newEnemy = Instantiate(enemy, transform.position, Quaternion.identity);
        }
    }
}
