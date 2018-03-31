using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Reference the player
    public GameObject player;
    //Vector 3 variable to offset camera
    private Vector3 offset;


    void Start()
    {
        // Set offset to current position - players position
        offset = transform.position - player.transform.position;

    }
    void LateUpdate()
    {
        // Set current position to players position + offset position
        transform.position = player.transform.position + offset;
    }
}
