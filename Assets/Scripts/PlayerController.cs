﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DontFallOff
{

    public class PlayerController : MonoBehaviour
    {
        public float speed;
        private Rigidbody rb;
        private int count;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
        }

        void FixedUpdate()
        {
            //Set float for Horizontal and Vertical movement
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            //Set a new vector 3 called movement to value of horizontal and vertical movements
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            //Add force to rigidbody
            rb.AddForce(movement * speed);

        }
    }
}