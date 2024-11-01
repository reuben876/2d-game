using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D Player;

    private float moveSpeed;
    private float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;


    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.GetComponent<Rigidbody2D>();
    // Speed and height the player can jump and move
        moveSpeed = 1.5f;
        jumpForce = 30f;
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
    // Getting inputs from Unity
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
    // links input to movement
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            Player.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        }

        if (!isJumping && moveVertical > 0.1f)
        {
            Player.AddForce(new Vector2(0f,moveVertical * jumpForce), ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    // This removes double jumping
        if(collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
    // This makes that player only able to jump once it is on an oject tagged as platform
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
    }
}
