using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System;



public class JumpController : MonoBehaviour
{

    public float jumpPower;
    public Rigidbody2D rb;


    
    



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           if(Physics2D.Raycast(transform.position, Vector2.down, 0.55f))
           {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
           }
        }
      
        if (Input.GetKeyUp(KeyCode.Space) && rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }
    }


}



