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
    public bool dying;
    public Animator anim;
    public static ZombieHealth instance;

    public float destructionDelay = 2f;
    float destructionTimer;

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
        if (isDead == false)
        {
            if (currentHealth <= 0)
            {
                Debug.Log("Dead");


                // for player attack script to edit game manager to know when enemy is dead
                isDead = true;



                // anim.SetTrigger("dying");
                anim.SetTrigger("isDead");

                destructionTimer += Time.deltaTime;

                if (destructionTimer >= destructionDelay)
                {
                    // power up player on death
                    UltimatePower.instance.ultimatePowerUpLevel = UltimatePower.instance.ultimatePowerUpLevel + powerUp;
                    Debug.Log("Destroy Dead");
                    OnDestroy();
                }
            }
        }
       

    }

    public void OnDestroy()
    {
        Destroy(gameObject);
    }

    public void HurtEnemy(int damageToZombie)
    {
        currentHealth -= damageToZombie;
    }



}
