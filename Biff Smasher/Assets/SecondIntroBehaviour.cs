using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondIntroBehaviour : StateMachineBehaviour
{
    private int random;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        random = Random.Range(0, 3);

        if (random == 0)
        {
            animator.SetTrigger("jumpSlam");
        }       
        if (random == 1)
        {
            animator.SetTrigger("secondIdle");
        }
        else
        {
            animator.SetTrigger("deathOrbs");
        }
        animator.ResetTrigger("secondIntro");
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

}
