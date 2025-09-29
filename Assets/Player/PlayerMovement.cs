using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class PlayerMovement : MonoBehaviour
{
// Horizontal Movement
    public Rigidbody2D RB;
    public float Movespeed;
    private float Horizontal;
    private bool isFacingRight;







    void Start()
    {
        
    }

    void Update()      
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        Flip();





    }

    private void FixedUpdate()
    {

        RB.linearVelocity = new Vector2(Horizontal * Movespeed, RB.linearVelocity.y);
    }

    private void Flip()
    {
        if (isFacingRight && Horizontal > 0f || !isFacingRight && Horizontal < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }






}
