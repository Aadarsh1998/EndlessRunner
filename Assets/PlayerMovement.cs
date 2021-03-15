using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float playerspid;
    SpriteRenderer playerSprite;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        FlipPlayer();
    }
    void FixedUpdate()
    {
        float xInput = 0;
        if(Input.GetMouseButtonDown(0))
        {
            //print("button pressed");
            
            
                
                if(Input.mousePosition.x > Screen.width / 2)
                {
                    xInput = 1.0f;
                    print("movee right");
                }
                else if(Input.mousePosition.x < Screen.width / 2)
                {
                    xInput = -1.0f;
                    
                    print("move left");
                }
                else
                {
                    xInput = 0;
                    print("Movement halted");
                }
            rb.AddForce(transform.right * playerspid * xInput);

        }
    }
    private void FlipPlayer()
    {
        if(rb.velocity.x>0)
        {
            playerSprite.flipX = false;
        }
        else if(rb.velocity.x<0)
        {
            playerSprite.flipX = true;
        }
    }
}
