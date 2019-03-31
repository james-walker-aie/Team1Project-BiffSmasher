using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public static Zombie instance;
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    float timer;
    public Animator animator;
    public Transform Waypoint;
    GameObject player;

    
    // is the enemy dead? if so don't worry about it.
    public bool isDead;
    public bool isKnockedBack;

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
    }

    // Start is called before the first frame update
    void Start()
    {
        Waypoint = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health.instance.currentHealth > 0)
        {
            if (Vector2.Distance(transform.position, Waypoint.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, Waypoint.position, speed * Time.deltaTime);
            }

        }
        else if (Health.instance.currentHealth <= 0)
        {
            Debug.Log("Zombie dance of joy");
            transform.position = Vector2.MoveTowards(transform.position, Waypoint.position, -speed * Time.deltaTime);
        }

        
        /*if (Vector2.Distance(transform.position, Waypoint.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Waypoint.position, speed * Time.deltaTime); 
        }  

        else if(Vector2.Distance(transform.position, Waypoint.position) < stoppingDistance && Vector2.Distance(transform.position, Waypoint.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }

        else if(Vector2.Distance(transform.position, Waypoint.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Waypoint.position, -speed * Time.deltaTime);
        }*/
        
    }

    // strike player and player loses health
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && Health.instance.currentHealth > 0)
        {
            animator.SetTrigger("attack");
            Health.instance.currentHealth -= attackDamage;
            Debug.Log(" hit player" + Health.instance.currentHealth);
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
}
