using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bashar : MonoBehaviour
{
    public float moveSpeed ; 
    public float jumpHeight ; 
    public KeyCode Spacebar ; 
    public KeyCode L ;
    public KeyCode R ; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(Spacebar) && grounded)
         {
            Jump(); 
         }
         if (Input.Getkey(L))
         {

           GetComponent<Rigidbody2D>().Velocity = New Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().Velocity.y) ;
        if (GeetComponent<Spriterenderer>()!=null){

            GeetComponent<Spriterenderer>().flipx = true ; 
        }

         }
         if (Input.Getkey(R))
         {
            GeetComponent<Rigidbody2D>().Velocity  = New Vector2 (moveSpeed, GetComponent<Rigidbody2D>().Velocity.y) ;
         
         if (GeetComponent<Spriterenderer>()!=null){

            GeetComponent<Spriterenderer>().flipx = false ; 
         }
         
         
         
         }
        void Jump() 
        {
              GeetComponent<Rigidbody2D>().Velocity = New Vector2(GetComponent<Rigidbody2D>().Velocity.x,jumpHeight) ;
         }


      void FixedUpdata(){

        grounded= Physics2D.OverlapCircle(groundCheck.position,groundCheckradius,whatISGround)
      }
        }
    }

