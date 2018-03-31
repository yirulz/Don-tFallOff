﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DontFallOff
{
    public class BallSpawner : MonoBehaviour
    {

        public GameObject[] balls;
        public Transform spawn;


        // Use this for initialization
        void Start()
        {
            StartCoroutine(spawner());
        }


        public IEnumerator spawner()
        {
            //keep active
            while (1 >= 0)
            {
                //return amount of time to wait in seconds
                yield return new WaitForSeconds(1);

                //call Spawn
                Spawn();
            }
        }
    

    void Spawn()
    {
        //Makes a randomized egg index for array
        int randomBall = Random.Range(0, balls.Length);

        //creates a random egg index
        GameObject randBall = balls[randomBall];

        //Sets position as current position
        Vector3 position = transform.position;

        // clone is now instantiating a egg from a random index from eggs
        GameObject clone = Instantiate(randBall);

        // set position of egg spawning
        clone.transform.position = position;
    }
}
}