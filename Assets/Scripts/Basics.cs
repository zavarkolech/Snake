
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using System.Runtime.CompilerServices;
using UnityEditor;
using Unity.VisualScripting;


public class Basics : MonoBehaviour
{
   
    public GameObject[] objs = new GameObject[3];

    public Transform target;

    public BoxCollider box;

    public Light _light;

    public Transform[] transforms = new Transform[3];

    public float speed = 2f, RotateSpeed = 10f;
    
    

        private void Update()
    {
        for (int i = 0; i < transforms.Length; i++) {

            if(transforms[i] == null)
            continue;
        transforms[i].Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        transforms[i].Rotate(new Vector3(30, 0, 0) * RotateSpeed * Time.deltaTime);

        float posX = transforms[i].position.x;
        if(posX > 10f && transforms[i].gameObject.name == "Cube")
        Destroy(transforms[i].gameObject); 
    }
    }

    

}