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
    public int currentHealth;
    public int maxHealth = 100;
    private bool isDead;

    public Animator anim;
    public float restartDelay = 2f;
    float restartTimer;

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
           // anim.SetTrigger("isDead");
            anim.SetTrigger("isDead");

            restartTimer += Time.deltaTime;

            if (restartTimer >= restartDelay)
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

    private void SetHealthUI()
    {
        
        healthbar.value = currentHealth; //Update Slider's Value To Equal Player's Health
    }
}
