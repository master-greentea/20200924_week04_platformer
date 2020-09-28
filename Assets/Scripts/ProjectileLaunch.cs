using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLaunch : MonoBehaviour
{
    public float rotationSpeed = 420f;
    public float shootForce = 880f;
    public Rigidbody2D Flame;
    float minR = 1;
    float maxR = 45;
    // aiming cannon and left click to shoot
    void Update()
    {
        // move mouse to aim
        // -1f is move mouse left, 1f move mouse right, 0f not moving mouse horizontally
        float vertiMouseSpeed = Input.GetAxis("Mouse Y");

        // transform.Rotate(0, 0, horiMouseSpeed); // is framerate dependent
        transform.Rotate(0, 0, vertiMouseSpeed * Time.deltaTime * rotationSpeed); // framerate independent
        // dT usually a very small number between 0.0 - 1.0

        // lock rotation?
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        currentRotation.z = Mathf.Clamp(currentRotation.z, minR, maxR);
        transform.localRotation = Quaternion.Euler(currentRotation);

        // click to shoot ball
        // instantiate ("clone") an object
        if (Input.GetMouseButtonDown(0)) {
            Rigidbody2D newClone = Instantiate(Flame, transform.position + transform.right, Quaternion.identity); //quaternion? 0, 0, 0, 0
            // adding force to "down"
            newClone.AddForce(transform.right * shootForce);
        }
    }
}
