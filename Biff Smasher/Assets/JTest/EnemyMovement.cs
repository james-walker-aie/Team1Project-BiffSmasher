using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    // simple move left script
    public float moveSpeed;

    public Vector2 startDirection;

    // is the enemy dead? if so don't worry about it.
    public bool isDead;
    public bool isKnockedBack;


    //Health
    // public bool hurtEnemy;
    public float health = 2;



    public Vector2 moveDir;
    // public float[] myArray;

    // rigidbody
    public Rigidbody2D rb;

    //knockback
    public float knockbackCounter, knockbackTime, knockbackForce;

    //weapon drop
    public GameObject[] weapons;
    public int dropSuccessRate = 20;

    // Update is called once per frame
    void Update()
    {

        if (knockbackCounter <= 0)
        {
            // simple move script
            transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
        }

        else
        {
            //simple knockback
            transform.position += new Vector3(moveDir.x * moveSpeed * Time.deltaTime, moveDir.y * moveSpeed * Time.deltaTime, 0f);
            knockbackCounter -= Time.deltaTime;
        }
    }


    public void Movement()
    {
        // move the enemy get values from array


    }


    public void Knockback(Vector3 dir)
    {
        knockbackCounter = knockbackTime;

        //calculate move enemy values
        moveDir.x = dir.x * knockbackForce;
        moveDir.y = knockbackForce;
    }

    public void FireballDamage()
    {
        health = health - 10;
    }

    public void HurtEnemy()
    {
        health--;
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

