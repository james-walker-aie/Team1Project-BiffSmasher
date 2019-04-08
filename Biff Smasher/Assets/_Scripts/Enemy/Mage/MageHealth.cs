﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageHealth : MonoBehaviour
{
    // health
    public int currentHealth;
    public int maxHealth = 50;
    public bool isDead;

    //power up player
    public int powerUp;

    // reference to 
    public bool dying = false;
    public Animator anim;
    public static MageHealth instance;

    public float destructionDelay = 2f;
    float destructionTimer;

    public bool isBeaten = false;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        anim.GetComponent<Animator>();

    }

    //Update is called once per frame
    void Update()
    {
       
        if (currentHealth <= 0)
        {
            // for player attack script to edit game manager script to know when enemy is dead
            isDead = true;

            if (isDead == true)
            {

                dying = true;

                // anim.SetTrigger("dying");
                anim.SetTrigger("isDead");

            }

            destructionTimer += Time.deltaTime;

            if (dying == true && destructionTimer >= destructionDelay)
            {

                PowerUp();
                
                Mage.instance.Drop();

                if (FightZone.wave1)
                {
                    Debug.Log("Mage beaten");

                    GameManager.instance.fightZone1Enemies--;
                }

                if (FightZone.wave2)
                {
                    Debug.Log("Mage beaten");

                    GameManager.instance.fightZone2Enemies--;
                }

                if (FightZone.wave3)
                {
                    Debug.Log("Mage beaten");

                    GameManager.instance.fightZone3Enemies--;
                }

                if (FightZone.wave4)
                {
                    Debug.Log("Mage beaten");

                    GameManager.instance.fightZone4Enemies--;
                }

                OnDestroy();
            }
        }

    }

    public void OnDestroy()
    {
        Destroy(gameObject);
    }

    public void HurtEnemy(int damageToMage)
    {
        currentHealth -= damageToMage;
    }

    public void PowerUp()
    {
        // power up player on death
        UltimatePower.instance.ultimatePowerUpLevel = UltimatePower.instance.ultimatePowerUpLevel + powerUp;
    }

    public void FireballDamage(int fBdamageToZombie)
    {
        currentHealth -= fBdamageToZombie;
    }

}
