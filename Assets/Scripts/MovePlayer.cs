using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5f, hSpeed = 10f, _thrust = 500f;

    private Rigidbody _rb;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
        float h = Input.GetAxis("Horizontal") * hSpeed * Time.fixedDeltaTime;

        _rb.velocity = transform.TransformDirection(new Vector3(h, _rb.velocity.y, v));
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Block")
        {
            _rb.AddForce(new Vector3(0, 1, 0) * _thrust);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            Debug.Log("Trigger correct");
            
        }       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            Debug.Log("Trigger Stay");
        }       
    }
     private void OnTriggerExit(Collider other)
     {
         if (other.gameObject.name == "Cube")
         {
             Destroy(gameObject);
         }       
     }



   
}
