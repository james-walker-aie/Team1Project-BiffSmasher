using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour
{
    public static Mage instance;
    public MageAttack mageAtk;

    // attack
    public float attackDelay;
    public float attackRange;    
    public int attackDamage = 10;

    // movement
    public float moveSpeed;
    public float stoppingDistance;
    public float retreatDistance;

    float timer;
    public Animator animator;
    public Transform Waypoint;
    GameObject player;

    
    public Transform groundCheck;
      
    // is the enemy dead? if so don't worry about it.
    public bool isDead;
    public bool isKnockedBack;
    public bool canWalk;

    //knockback
    public float knockbackCounter, knockbackTime, knockbackForce;

    //weapon drop
    public GameObject[] weapons;
    public int dropSuccessRate = 20;

    //Health  
    public float health = 20;   
    
    private void Awake()
    {
        instance = this;
        canWalk = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        Waypoint = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (canWalk == true)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }

        //animator.SetTrigger("walk");
        RaycastHit2D groundInfo = Physics2D.Raycast(groundCheck.position, Vector2.down, 2f);

        // check distance between zombie and player to see if able to attack             
    }

   
     public void OnTriggerEnter2D(Collider2D col)
     {
        if (col.gameObject.CompareTag("Player") && Health.instance.currentHealth > 0)
        {
            mageAtk.CheckIfTimeToFire();
            animator.SetTrigger("attack");
            canWalk = false;
            //Health.instance.currentHealth -= attackDamage;
            Debug.Log(" hit player" + Health.instance.currentHealth);
        }
        else
        {
            canWalk = true;
        }
     }

    

    public void FireballDamage()
    {
        health = health - 10;

        // drop random weapon
        int randomChance = Random.Range(0, 100);
        if (randomChance < dropSuccessRate)
        {
            int randomPick = Random.Range(0, weapons.Length);
            Instantiate(weapons[randomPick], transform.position, transform.rotation);
        }
    }

    public void HurtEnemy()
    {
        health = health - 10;
        // hurtEnemy = false;
        if (health <= 0)
        {
            // GameManager.instance.AddScore(scoreValue);

            // drop random weapon
            int randomChance = Random.Range(0, 100);
            if (randomChance < dropSuccessRate)
            {
                int randomPick = Random.Range(0, weapons.Length);
                Instantiate(weapons[randomPick], transform.position, transform.rotation);
            }
          
            // Destroy(gameObject);
            // Instantiate(deathEffect, transform.position, transform.rotation);
        }
    }

    public void Drop()
    {
        // drop random weapon
        int randomChance = Random.Range(0, 100);
        if (randomChance < dropSuccessRate)
        {
            int randomPick = Random.Range(0, weapons.Length);
            Instantiate(weapons[randomPick], transform.position, transform.rotation);
        }
    }
}
