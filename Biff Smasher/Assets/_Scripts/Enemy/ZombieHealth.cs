using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
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
    public static ZombieHealth instance;

    public float destructionDelay = 2f;
    float destructionTimer;

    public bool isBeaten =false;
    
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
        Debug.Log(  gameObject.name + "  " + currentHealth);
  
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

                PowerUp();
                OnDestroy();

                }

            }
        
       

    }

    public void OnDestroy()
    {
        Destroy(gameObject);

    }

    public void PowerUp()
    {
        // power up player on death
        UltimatePower.instance.ultimatePowerUpLevel = UltimatePower.instance.ultimatePowerUpLevel + powerUp;
    }

    public void HurtEnemy(int damageToZombie)
    {
        currentHealth -= damageToZombie;
    }



}
