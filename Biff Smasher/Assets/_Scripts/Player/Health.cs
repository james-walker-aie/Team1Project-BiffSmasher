using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 100;
    private bool isDead;

    public Animator anim;
    public float restartDelay = 4f;
    float restartTimer;



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

   
}
