using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public gameManager manage;
    public float moveInput;
    public float speed;
    public float jumpForce;
    public float up ;
    public float down;
    public 

    void FixedUpdate(){
    
        moveInput = Input.GetAxisRaw("Horizontal");
        // if(moveInput != 0)
            rb.AddForce(new Vector2(moveInput*speed, 0f));
          if(rb.position.y<-3){
              manage.EndGame();
          }  
    }
    public void GiveForce(){
        rb.AddForce(new Vector2(0, 10f), ForceMode2D.Impulse);
    }
     public void upForce(){
        rb.AddForce(new Vector2(0, jumpForce +up), ForceMode2D.Impulse);
    }
     public void downForce(){
        rb.AddForce(new Vector2(0, jumpForce -down), ForceMode2D.Impulse);
    }
     public void storePosition(Vector3 pos ){
         transform.position = pos;
     }
   
}