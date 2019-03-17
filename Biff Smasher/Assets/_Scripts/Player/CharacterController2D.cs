using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    public float checkRadius;
    private bool facingRight;     // set default look direction to right.
    private bool isGrounded;        // determine if player is standing on ground.

    public bool branch = false;
    public bool axe = false;
    public bool sword = false;
    public bool ultimate = false;
      
    private bool slashAttack;
    private bool thrustAttack;
    private bool kick;
    private bool ultAttack;
    private bool jump;

    private Rigidbody2D rb;
    public SpriteRenderer sr;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    public Animator animator;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        slashAttack = false;
        thrustAttack = false;
        ultAttack = false;
        kick = false;
        jump = false;
        facingRight = true;
    }


    void Update()
    {
        HandleInput();
        AnimationControl();
    }


    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        HandleMovement(horizontal);

        Flip(horizontal);
        HandleAttacks();

        ResetValues();

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround );         // circle collider to check collision with ground.            
    }


    private void HandleMovement(float horizontal)
    {
        if (!this.animator.GetCurrentAnimatorStateInfo(0).IsTag("SlashAttack"))  
        {
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        }
        else if(animator.GetCurrentAnimatorStateInfo(0).IsTag("SlashAttack"))  // to stop player from moving when attack is pressed
        {
            rb.velocity = new Vector2(0, 0);
        }

        animator.SetFloat("Speed", Mathf.Abs(horizontal));
    }
    


    private void HandleAttacks()
    {
        if (slashAttack && !this.animator.GetCurrentAnimatorStateInfo(0).IsTag("SlashAttack"))   
        {
            animator.SetTrigger("slashAttack");
            
        }

        if (thrustAttack && !this.animator.GetCurrentAnimatorStateInfo(0).IsTag("ThrustAttack"))
        {
            animator.SetTrigger("thrustAttack");

        }

        if (kick && !this.animator.GetCurrentAnimatorStateInfo(0).IsTag("Kick"))
        {
            animator.SetTrigger("kick");

        }

        if (ultAttack && !this.animator.GetCurrentAnimatorStateInfo(0).IsTag("UltAttack"))
        {
            animator.SetTrigger("ultAttack");

        }     

    }


    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            slashAttack = true;
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            thrustAttack = true;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ultAttack = true;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            kick = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))                     // player jump.
        {
            rb.velocity = Vector2.up * jumpForce;
            animator.SetTrigger("jump");
            jump = true;
        }

    }



    private void Flip(float horizontal)   // flip direction character is facing when button pressed.
    {     
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }



    private void ResetValues()  // function used to reset all values of attack, jump etc.
    {
        slashAttack = false;
        thrustAttack = false;
        ultAttack = false;
        kick = false;
        jump = false;

    }


    void AnimationControl()
    {
        if (branch == false)                // when branch object collected set animation layer to branch animations.
        {
            animator.SetLayerWeight(1, 0);
        }
        else
        {
            animator.SetLayerWeight(1, 1);
        }

        if (axe == false)                 // when axe object collected set animation layer to axe animations.
        {
            animator.SetLayerWeight(2, 0);
        }
        else
        {
            animator.SetLayerWeight(2, 2);
        }

        if (sword == false)                 // when sword object collected set animation layer to sword animations.
        {
            animator.SetLayerWeight(3, 0);
        }
        else
        {
            animator.SetLayerWeight(3, 3);
        }

        if (ultimate == false)                 // when ultiamte object collected set animation layer to ultiamte animations.
        {
            animator.SetLayerWeight(4, 0);
        }
        else
        {
            animator.SetLayerWeight(4, 4);
        }
    }



}
