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
            if (score >= 1)
            {
                alertText.text = "Well Done";
                countDown -= Time.deltaTime;
                countDownText.text = "Next level in: " + countDown;

            }
            if (countDown <= 0)
            {
                SceneManager.LoadScene("Level_02");
            }
        }
    }
}