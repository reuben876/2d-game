using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;  // Reference to the player's transform

    private float offsetX;    // Horizontal offset between the player and the camera

    // Start is called before the first frame update
    void Start()
    {
        offsetX = transform.position.x - Player.position.x;
    }

    private void LateUpdate()
    {
        // Update the camera's position to follow the player horizontally
        transform.position = new Vector3(Player.position.x + offsetX, transform.position.y, transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
