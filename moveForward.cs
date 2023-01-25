using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float speed = 4.0f;

    void Update(){
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
         if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
         }
    }
}
