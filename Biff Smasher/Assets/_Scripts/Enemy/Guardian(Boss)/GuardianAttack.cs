using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardianAttack : MonoBehaviour
{
    public int damageToGive;
    public GameObject damageBust;
    public Transform guardianHit;
    public AudioSource hitSound;
  
    //public float attackDelay = 100;
    //float lastAttacked = -9999;
    
    public Animator animator;
  
    float attackRate;
    float nextAttack;

    private void Start()
    {
        attackRate = 2f;
        nextAttack = Time.time;
    }

    private void Update()
    {

    }

    public void TimeToAttack()
    {

        if (Time.time > nextAttack)
        {
            
            nextAttack = Time.time + attackRate;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Time.time > nextAttack && Health.instance.currentHealth > 0)
            {                
                nextAttack = Time.time + attackRate;
                other.gameObject.GetComponent<Health>().HurtPlayer(damageToGive);
                Instantiate(damageBust, guardianHit.position, guardianHit.rotation);
                hitSound.Play();
            }            
        }
    }







    /*private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Time.time > lastAttacked + attackDelay)
            {
                animator.SetTrigger("Attack");
            }

            if (Health.instance.currentHealth > 0)
            {
                other.gameObject.GetComponent<Health>().HurtPlayer(damageToGive);
                Instantiate(damageBust, guardianHit.position, guardianHit.rotation);
                hitSound.Play();
            }
        }
        lastAttacked = Time.time;

    }*/



    /* private void Start()
     {
         //hitSound = GetComponent<AudioSource>();
     }

     void Update()
     {

     }

     private void OnTriggerEnter2D(Collider2D other)
     {
         if (other.gameObject.tag == "Player")
         {
             other.gameObject.GetComponent<Health>().HurtPlayer(damageToGive);
             Instantiate(damageBust, guardianHit.position, guardianHit.rotation);
             hitSound.Play();


         }
     }*/

}
