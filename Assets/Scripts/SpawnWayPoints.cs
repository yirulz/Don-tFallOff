using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DontFallOff
{
    public class SpawnWayPoints : MonoBehaviour
    {
        public Transform waypointGroup;
        public float moveSpeed = 5f;
        private Transform[] waypoints;
        private int currentIndex = 0;


        // Use this for initialization
        void Start()
        {
            // length is assigned to amount of children in waypointGroup
            int length = waypointGroup.childCount;
            // waypoints is assigned array
            waypoints = new Transform[length];

            //forward loop for way points
            for (int i = 0; i < length; i++)
            {
                //assign waypoints (number) to children in waypointGroup (according to order)
                waypoints[i] = waypointGroup.GetChild(i);
            }

        }


        void Update()
        {

            Transform current = waypoints[currentIndex];
            //Set position
            Vector3 position = transform.position;
            //Identify direction
            Vector3 direction = current.position - position;
            //Move in diretion at moveSpeed 
            position += direction.normalized * moveSpeed * Time.deltaTime;
            //Setting position transform for next movement
            transform.position = position;

            float distance = Vector3.Distance(position, current.position);
            

            if (distance <= 1)
            {
                // Switch to next waypoint
                currentIndex++;
            }

            //If index is greater then amount of waypoints
            if (currentIndex >= waypoints.Length)
            {
                //Set index back to 0
                currentIndex = 0;
            }


        }
    }
}