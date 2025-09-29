using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;



public class JumpController : MonoBehaviour
{

    public bool isJumping = false;

    public float jumpPower;
    public Rigidbody2D rb;
    private LayerMask Ground;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)  
        {
           
            if (Physics2D.Raycast(transform.position, Vector2.down, 0.01f))
            {                           
                    GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10, ForceMode2D.Impulse);              
            }
            else
            {
                isJumping = true;
            }
            
        }

    }


}


