using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DontFallOff
{

    public class PlayBoundary : MonoBehaviour
    {

        public GameObject player;
        
         void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Balls"))
            {
                Destroy(other.gameObject);
            }
            if (other.gameObject.CompareTag("Player"))
            {
                player.transform.position = new Vector3(0f, 0.5f, 0f);
            }
        }

    }
}