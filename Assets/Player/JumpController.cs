using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System;



public class JumpController : MonoBehaviour
{

    public float jumpPower;
    public Rigidbody2D rb;

    public LayerMask groundLayer;
    public Transform groundCheck;
    public float groundCheckRadius = 0.1f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


        if (Input.GetKeyDown(KeyCode.Space)) 
        {
                rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.Space) && rb.linearVelocity.y > 0) 
        {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }







    }
}



