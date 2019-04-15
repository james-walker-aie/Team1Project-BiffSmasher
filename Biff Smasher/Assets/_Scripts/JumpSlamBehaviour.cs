using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSlamBehaviour : StateMachineBehaviour
{     
    public float speed;
    public float jumpForce;

   
    private Rigidbody2D rb;
    private Transform playerPos;

    private int random;    

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        random = Random.Range(0, 2);
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();   // get transform of player for guardian to jump towards                      
        rb = GameObject.FindGameObjectWithTag("Guardian").GetComponent<Rigidbody2D>();     // get rigidbody of the guardian
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.up * jumpForce;    // add force to make guardian jump

       if (random == 0)
       {
            animator.SetTrigger("secondIdle");
       }
       else
       {
            animator.SetTrigger("deathOrbs");

       }
        
        Vector2 target = new Vector2(playerPos.position.x, animator.transform.position.y); // jump movement of guardian towards player.
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, target, speed * Time.deltaTime);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

}
