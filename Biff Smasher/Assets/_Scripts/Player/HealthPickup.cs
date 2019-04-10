﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    Health health;

    public float healthBonus = 15f;

    private void Awake()
    {
        health = FindObjectOfType<Health>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(health.currentHealth < health.maxHealth)
        {
            OnDestroy();
            health.currentHealth = health.currentHealth + healthBonus;
        }
              
    }

    public void OnDestroy()
    {
        Destroy(gameObject);

    }

}
