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

            if (Physics.Raycast(transform.position, fwd, out hit, 10))
            {
                if (hit.collider.CompareTag("PickUp"))
                {
                    StartCoroutine(WaitForText());
                }
            }
        }

        public IEnumerator WaitForText()
        {
            alertText.text = "Pick up in front!";
            yield return new WaitForSeconds(1);
            alertText.text = "";

        }
    }
}