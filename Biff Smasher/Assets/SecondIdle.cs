﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondIdle : StateMachineBehaviour
{
    private int random;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        random = Random.Range(0, 2);

        if (random == 0)
        {
            animator.SetTrigger("deathOrbs");
        }
        else
        {
            animator.SetTrigger("jumpSlam");
        }

    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
