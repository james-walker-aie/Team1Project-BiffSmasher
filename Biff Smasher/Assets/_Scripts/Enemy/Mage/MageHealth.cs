using System.Collections;
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
    private bool dying;
    public Animator anim;
    public static MageHealth instance;

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
       
        if (currentHealth <= 0)
        {
            // for player attack script to edit game manager script to know when enemy is dead
            isDead = true;

            // power up player on death
            UltimatePower.instance.ultimatePowerUpLevel = UltimatePower.instance.ultimatePowerUpLevel + powerUp;

            // anim.SetTrigger("dying");
            anim.SetTrigger("isDead");

            destructionTimer += Time.deltaTime;

            if (destructionTimer >= destructionDelay)
            {
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



}
