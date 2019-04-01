using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    // health
    public int currentHealth;
    public int maxHealth = 50;

    // reference to 
    private bool dying;
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
       
        if (currentHealth <= 0)
        {
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

}
