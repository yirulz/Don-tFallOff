using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DontFallOff
{

    public class ScoreCubes : MonoBehaviour
    {
    
        public Goal score;

        // Update is called once per frame
        void Update()
        {
            //rotate object with new vector 3 times time.deltatime
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

            //If you collect 10 score cubes, display message saying you win and go to next level
          
        }

        // When picked up destroy object and add to score
        void OnTriggerEnter(Collider other)
        {
            //If player enters the cube
            if (other.gameObject.CompareTag("Player"))
            {
                //Destroy the pickup
                Destroy(this.gameObject);
                score.score++;
            }

        }
    }
}