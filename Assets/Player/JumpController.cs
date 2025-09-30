using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System;



public class JumpController : MonoBehaviour
{

    public float jumpPower;
    public Rigidbody2D rb;
    bool isJumping = false;







    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
         rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpPower);
            isJumping = true;
        }
      
        if (Input.GetKeyUp(KeyCode.Space) && rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
    }


}



