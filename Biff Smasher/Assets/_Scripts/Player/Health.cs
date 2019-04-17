using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //Reference To Slider
    public Slider healthbar;

    public static Health instance;
    public float currentHealth;
    public float maxHealth = 100;
    public bool isDead;

    public Animator anim;
    public float restartDelay = 2f;
    float restartTimer;
    public bool dying = false;

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
        
        SetHealthUI();

        if (currentHealth <= 0)
        {

            isDead = true;

            if (isDead == true)
            {

                dying = true;

                // anim.SetTrigger("dying");
                anim.SetTrigger("isDead");
                restartTimer += Time.deltaTime;

            }           

            if (dying == true && restartTimer >= restartDelay)
            {
                RestartScene();
            }
        }

    }

   
    public void RestartScene()
    {
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }

    public void SetHealthUI()
    {
        
        healthbar.value = currentHealth; //Update Slider's Value To Equal Player's Health
    }


    public void HurtPlayer(int damageToGive)
    {
        currentHealth -= damageToGive;
        
    }

    public void FireballDamage(int fireDamageToGive)
    {
        currentHealth -= fireDamageToGive;
    }
}
