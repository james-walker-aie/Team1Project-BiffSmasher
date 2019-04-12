using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guardian : MonoBehaviour
{
    public GuardianAttack guardianAttack;
    public DeathOrbAttack deathOrbAttack;

    // movement
    public float moveSpeed;

    public bool canWalk;

    public Animator animator;       
    public Transform groundCheck;
    public Transform Waypoint;
    public GameObject bossHealthBar;


    private void Awake()
    {        
        canWalk = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        bossHealthBar.SetActive(false);
        Waypoint = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (canWalk == true)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            animator.SetTrigger("Walk");
        }
                
        RaycastHit2D groundInfo = Physics2D.Raycast(groundCheck.position, Vector2.down, 2f);
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        bossHealthBar.SetActive(true);
        
        if (col.gameObject.CompareTag("Player") && Health.instance.currentHealth > 0)
        {
            guardianAttack.TimeToAttack();
            deathOrbAttack.CheckIfTimeToFire();
            animator.SetTrigger("Attack");
            animator.SetTrigger("deathOrbs");
            canWalk = false;
        }
        else
        {
            canWalk = true;
        }
    }

   
}
