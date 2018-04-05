using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace DontFallOff
{


    public class Goal : MonoBehaviour
    {
        public Text alertText;
        public Text countDownText;

        public float countDown = 10f;
        public int score;


        // Use this for initialization
        void Start()
        {
            alertText.text = "";
            countDownText.text = "";
        }

        // Update is called once per frame
        void Update()
        {
            //If score is 5
            if (score >= 5)
            {

                //Text displays well done and counts down to next level
                alertText.text = "Well Done";
                countDown -= Time.deltaTime;
                countDownText.text = "Next level in: " + Mathf.RoundToInt(countDown);

            }
            if (countDown <= 0)
            {
                SceneManager.LoadScene("Level_02");
            }
        }
    }
}