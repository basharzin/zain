using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bmen : MonoBehaviour
{
    
    public float moveSpeed;
    public float jumpHeight; 
    
    // Input Key Codes
    public KeyCode Spacebar; 
    public KeyCode L; 
    public KeyCode R; 

    
    public Transform groundCheck; 
    public float groundCheckRadius; 
    public LayerMask whatIsGround; 
    private bool grounded; 
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void FixedUpdate()
    {
        
        
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); 
    }

    
    void Update()
    {
        
        if (Input.GetKeyDown(Spacebar) && grounded)
        {
            Jump(); 
        }

        
        if (Input.GetKey(L)) 
        {
            
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

            
            if (GetComponent<SpriteRenderer>() != null)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
        }

        
        if (Input.GetKey(R)) 
        {
            
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

            
            if (GetComponent<SpriteRenderer>() != null)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }

        anim.SetFloat("Speed",Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));


        anim.SetFloat("Height", GetComponent<Rigidbody2D>().velocity.y);


        anim.SetBool("Grounded", grounded);

    }


    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }
}