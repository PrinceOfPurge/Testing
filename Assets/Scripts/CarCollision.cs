using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    Rigidbody2D body;

    CarMovement movement;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        movement = GetComponent<CarMovement>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BoostPad") 
        {
            movement.ApplySpeedBoost();
        }
    }
}
