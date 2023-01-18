using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    // Defines how fast the car will move (can be edited in Unity)
    public float driveSpeed;

    // Defines how fast the car will rotate (can be edited in Unity)
    public float rotSpeed;

    // Update is called once per frame
    void Update()
    {
        // Sets inputx to a value of 1 if A is pressed, -1 if D is pressed, and 0 if neither or both are pressed.
        float inputX = Input.GetAxis("Horizontal");
        // Sets inputx to a value of 1 if W is pressed, -1 if S is pressed, and 0 if neither or both are pressed.
        float inputY = Input.GetAxis("Vertical");

        // Translates the current object
        //  Vector3.forward: Is a pre-defined vector with 3 components (0,1,0) pointing upwards
        //  inputY
        //  driveSpeed: Defines how fast the car will rotate
        //  Time.deltaTime: Counts the time between frames (will account for differences in frame rate).
        transform.Translate(Vector3.forward * inputY * driveSpeed * Time.deltaTime);


        // Rotates the current object around an axis
        //  Vector3.up: Is a pre-defined vector with 3 components (0,1,0) pointing upwards

        //  inputX
        //  rotSpeed: Defines how fast the car will rotate
        //  Time.deltaTime: Counts the time between frames (will account for differences in frame rate).
        transform.Rotate(Vector3.up, inputX * rotSpeed * rotSpeed * Time.deltaTime);

    }
}
