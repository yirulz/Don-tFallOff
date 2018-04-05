using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DontFallOff
{

    public class RayCastDestroy : MonoBehaviour
    {
        public RaycastHit hit;
        public Text alertText;

        void FixedUpdate()
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            //Raycast forward
            if (Physics.Raycast(transform.position, fwd, out hit, 10))
            {
                //If item in front has tag of PickUp
                if (hit.collider.CompareTag("PickUp"))
                {
                    //Display text that alerts place to pickUp in front
                    StartCoroutine(WaitForText());
                }
            }
        }

        public IEnumerator WaitForText()
        {
            //Displays message, waits 1 second, clears message
            alertText.text = "Pick up in front!";
            yield return new WaitForSeconds(1);
            alertText.text = "";

        }
    }
}