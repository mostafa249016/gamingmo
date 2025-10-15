using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bobby : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    public KeyCode Spacebar;
    public KeyCode LeftArrow;
    public KeyCode RightArrow;
    
    void Start(){

    }
    
        
    

    
   
    {void Update () {

    if(Input.GetKeyDown(KeyCode.Space)) 
    {
        Jump(); 
    }

    if (Input.GetKey(KeyCode.LeftArrow)) 
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        
    }

    if (Input.GetKey(KeyCode.RightArrow)) 
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        
    }
}

void Jump()
{
    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    
        
    }
}
if (Input.GetKey(KeyCode.LeftArrow)) 
{
    GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
    
    if(GetComponent<SpriteRenderer>() != null)
    {
        GetComponent<SpriteRenderer>().flipX = true;
    }
}

if (Input.GetKey(KeyCode.RightArrow)) 
{
    GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
    

    if(GetComponent<SpriteRenderer>() != null)
    {
        GetComponent<SpriteRenderer>().flipX = false;
    }
}
public Transform groundcheck;
public float groundcheckRadius;
public LayerMask whatIsGround;
private bool grounded;

void FixedUpdate(){
    grounded=Physics2D.overlapCircle(groundcheck.position,groundcheckRadius,whatIsGround);
}
void Update () {

    if(Input.GetKeyDown(KeyCode.Space) && grounded) 
    {
        Jump(); 
    }

    if (Input.GetKey(KeyCode.LeftArrow)) 
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        

        if(GetComponent<SpriteRenderer>() != null)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    if (Input.GetKey(KeyCode.RightArrow)) 
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        

        if(GetComponent<SpriteRenderer>() != null)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}