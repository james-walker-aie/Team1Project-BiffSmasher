using System.Collections;
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
        if(CharacterController2D.instance.isDead==false && health.currentHealth < health.maxHealth)
        {
            health.currentHealth = health.currentHealth + healthBonus;
            OnDestroy();
           
        }
              
    }

    public void OnDestroy()
    {
        Destroy(gameObject);

    }

}
