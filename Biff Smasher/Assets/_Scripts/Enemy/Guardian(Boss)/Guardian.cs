using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guardian : MonoBehaviour
{
    public GuardianAttack guardianAttack;
    public DeathOrbAttack deathOrbAttack;

      
    public Transform groundCheck;
    public GameObject bossHealthBar;   

    // Start is called before the first frame update
    void Start()
    {
        bossHealthBar.SetActive(false);     
        
    }

    // Update is called once per frame
    void Update()
    {    
        RaycastHit2D groundInfo = Physics2D.Raycast(groundCheck.position, Vector2.down, 2f);
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        bossHealthBar.SetActive(true);        
    }
  
}
