using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuardianHealth : MonoBehaviour
{
    // health
    public int currentHealth;
    public int maxHealth = 200;
    public bool isDead;

    //power up player
    public int powerUp;

    // reference to 
    public bool dying = false;
    public Animator anim;
    public static ZombieHealth instance;

    public float destructionDelay = 2f;
    float destructionTimer;

    public bool isBeaten = false;
    public Slider healthBar;

  

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        anim.GetComponent<Animator>();
    }

    //Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + "  " + currentHealth);
        SetHealthUI();

        if (currentHealth <= 0)
        {
            // for player attack script to edit game manager to know when enemy is dead
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
                            
                OnDestroy();
            }
        }
    }
    public void SetHealthUI()
    {
        healthBar.value = currentHealth; //Update Slider's Value To Equal Player's Health
    }

    public void OnDestroy()
    {
        Destroy(gameObject);
    } 

    public void HurtEnemy(int damageToGuardian)
    {
        currentHealth -= damageToGuardian;
    }

    public void FireballDamage(int fBdamageToGuardian)
    {
        currentHealth -= fBdamageToGuardian;
    }
  
}
