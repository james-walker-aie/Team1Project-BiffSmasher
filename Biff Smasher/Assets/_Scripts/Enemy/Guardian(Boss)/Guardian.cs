using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardian : MonoBehaviour
{
    public static Guardian instance;

    // attack
    public int attackDamage = 10;

    // movement
    public float moveSpeed;
    public float stoppingDistance;
    public float retreatDistance;

    float timer;
    public Animator animator;   
    GameObject player;
    public Transform groundCheck;

    public GameObject bossHealthBar;
    
    public float health = 200;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireballDamage()
    {
        health = health - 30;      
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        animator.SetTrigger("Attack");
        gameObject.SetActive(bossHealthBar);
        if (col.gameObject.CompareTag("Player") && Health.instance.currentHealth > 0)
        {

            Health.instance.currentHealth -= attackDamage;
            Debug.Log(" hit player" + Health.instance.currentHealth);
        }
    }
}
