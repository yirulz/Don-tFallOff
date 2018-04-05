using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DontFallOff
{

    public class PlayBoundary : MonoBehaviour
    {

        public GameObject player;
       
        private Vector3 respawnPoint = new Vector3 (0f, 0.5f, 0f);

        void OnTriggerExit(Collider other)
        {
            //If any balls roll out of play boundary
            if (other.gameObject.CompareTag("Balls"))
            {
                //Destroy the ball
                Destroy(other.gameObject);
            }
            //If player falls out of play boundary
            if (other.gameObject.CompareTag("Player"))
            {
                //Respawn player
                player.transform.position = respawnPoint;
               
            }
        }

    }
}