using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables for player controller
    public float horizontalInput;
    public float speed = 10f;
     public float xRange = 10;
    void Update()
    {
        if(transform.position.x < -xRange){
            transform.position = new vector3(-xRange,transform.position.y, transform.position.z);
        }
        if(transform.position.x < xRange){
            transform.position = new vector3(xRange,transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

}

