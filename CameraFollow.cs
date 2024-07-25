using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;  // Reference to the player's transform

    private float offsetX;    // Horizontal offset between the player and the camera

    void Start()
    {
        // Calculate the initial horizontal offset
        offsetX = transform.position.x - Player.position.x;
    }

    void LateUpdate()
    {
        // Update the camera's position to follow the player horizontally
        transform.position = new Vector3(Player.position.x + offsetX, transform.position.y, transform.position.z);
    }
}
