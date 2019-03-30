using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 100;
    private bool isDead;

    

    public void RestartScene()
    {
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if (currentHealth <= 0)
        {
            
            RestartScene();
        }
    }

    void Die()
    {
        
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }
}
