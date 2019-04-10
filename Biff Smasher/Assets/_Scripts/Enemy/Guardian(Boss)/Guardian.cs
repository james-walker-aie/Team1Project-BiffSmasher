using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardian : MonoBehaviour
{
    public static Guardian instance;
    public GuardianAttack guardianAttack;

    // attack
    //public int attackDamage = 10;

    // movement
    public float moveSpeed;
    public float stoppingDistance;
    public float retreatDistance;

    public bool isDead;
    float timer;

    public Animator animator;   
    GameObject player;

    public Transform groundCheck;
    public Transform Waypoint;

    public GameObject bossHealthBar;
    
    public float health = 200;

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
        
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        animator.SetTrigger("Walk");
        RaycastHit2D groundInfo = Physics2D.Raycast(groundCheck.position, Vector2.down, 2f);
        
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        gameObject.SetActive(bossHealthBar);
        animator.SetTrigger("Attack");
        if (col.gameObject.CompareTag("Player") && Health.instance.currentHealth > 0)
        {
            guardianAttack.TimeToAttack();           
            
            //Health.instance.currentHealth -= attackDamage;

        }
    }

    public void FireballDamage()
    {
        health = health - 30;
    }
}
