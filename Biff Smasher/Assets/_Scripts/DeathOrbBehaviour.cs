using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOrbBehaviour : StateMachineBehaviour
{
    private int random;

    [SerializeField]
    GameObject fireball;
  
    private Transform fireballSpawn;


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        random = Random.Range(0, 2);

        fireballSpawn = GameObject.FindGameObjectWithTag("GuardianDeathOrb").GetComponent<Transform>();
        Instantiate(fireball, fireballSpawn.position, Quaternion.identity);

        if (random == 0)
        {
            animator.SetTrigger("secondIdle");
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
