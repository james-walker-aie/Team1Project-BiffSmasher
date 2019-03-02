using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;
    public SpriteRenderer sr;

    //private bool facingRight = true;   // set default look direction to right.
    private bool isGrounded;          // determine if player is standing on ground.
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public Animator animator;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround );         // circle collider to check collision with ground.

        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(moveInput));


    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))                     // player jump.
        {
            rb.velocity = Vector2.up * jumpForce;
            animator.SetTrigger("jump");
        }

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger("punch");
        }


        if (moveInput > 0)                                    // to change the players looking direction from right to left.
        {
            sr.flipX = false;
        }
        else if (moveInput < 0)
        {
            sr.flipX = true;
        }
    }

   

}
