using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [Header("Player Stats")]
    public float jumpHeight;
    private Rigidbody rb;
    private Vector2 direction;
    public bool doubleJump;
    public int numberOfJumps = 0;
    public UnityEvent jumpEvent;
    
    
    
    [Header("Ground Check")]
    public bool isGrounded;//Are we able to jump 
    public Transform groundCheck; //Are we tuching the ground
    public float groundCheckRadius; //Making an area to cheak ground
    public LayerMask whatIsGround; //What is the ground
    private float moveVelocity;

    private Vector3 velocity;
    public float gravity = -9.81f;

    public bool IsGrounded
    {
        get => isGrounded;
        set => isGrounded = value;
    }
    private void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, whatIsGround);
                
        if (/* Input.GetKeyDown(KeyCode.Space)&& isGrounded*/ Input.GetMouseButtonDown(0) )
        {
            Jump();
            jumpEvent.Invoke();
                    
        }
        /*if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
            {
                
            }
        }*/
    }

    public void Jump()
    {
        if (isGrounded)
        {
            numberOfJumps = 0;
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            numberOfJumps++;
        }
        else
        {
            if (numberOfJumps != 1) return;
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            numberOfJumps++;
        }
            
        //rb.AddForce(Vector2.up * jumpHeight);
    }
}
