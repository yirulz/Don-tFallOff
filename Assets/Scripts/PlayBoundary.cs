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
            if (other.gameObject.CompareTag("Balls"))
            {
                Destroy(other.gameObject);
            }
            if (other.gameObject.CompareTag("Player"))
            {
                player.transform.position = respawnPoint;
               
            }
        }

    }
}