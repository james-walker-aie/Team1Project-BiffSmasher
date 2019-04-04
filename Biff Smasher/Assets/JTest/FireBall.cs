using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{

    public Vector2 startDirection;
    Transform player;
    public float moveSpeed;
   // public Rigidbody2D MyRB;

    // Start is called before the first frame update
    void Start()
    {
          player = GameObject.FindWithTag("Player").transform;
        // determine dirction
         startDirection.x = player.position.x - transform.position.x;
        startDirection.Normalize();
    }  

    // Update is called once per frame
    void Update()
    {
        if(startDirection.x >= 0)
        {
            // flip x axis to right
            Vector3 theScale = transform.localScale;
            theScale.x = 1;
            transform.localScale = theScale;

           // Debug.Log("x value " + startDirection.x);
            // speed and direction 
            transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);

        }else
        {
            // flip x axis to left
            Vector3 theScale = transform.localScale;
            theScale.x = -1;
            transform.localScale = theScale;

          //  Debug.Log("x value " + startDirection.x);
            // speed and direction 
            transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);

        }


    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col != null)
        {
            if (col.gameObject.tag == "Enemy")

            {
                Debug.Log("Fireball damage " + col.gameObject.tag);
                if (col.gameObject.GetComponent<Zombie>().health > 0 && col.gameObject.GetComponent<Zombie>().isDead == false)
                {
                    Debug.Log("Fireball damage current health " + col.gameObject.GetComponent<Zombie>().health);
                    col.gameObject.GetComponent<Zombie>().FireballDamage();
                    Debug.Log("Fireball damage hurt enemy " + col.gameObject.GetComponent<Zombie>().health);

                    // knockback direction
                   // Vector2 hitDir = col.transform.position - this.transform.position;
                   // hitDir = hitDir.normalized;
                  //  col.gameObject.GetComponent<Zombie>().Knockback(hitDir);

                }

                if (col.gameObject.GetComponent<Zombie>().health <= 0 && FightZone.wave1 && col.gameObject.GetComponent<Zombie>().isDead == false)
                {
                    Debug.Log("Fireball damage destroy enemy");
                    col.gameObject.GetComponent<Zombie>().isDead = true;
                    GameManager.instance.fightZone1Enemies--;
                    Destroy(col.gameObject, .1f);

                }

                if (col.gameObject.GetComponent<Zombie>().health <= 0 && FightZone.wave2 && col.gameObject.GetComponent<Zombie>().isDead == false)
                {
                    Debug.Log("Fireball damage destroy enemy");
                    col.gameObject.GetComponent<Zombie>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.instance.fightZone2Enemies--;


                }
                if (col.gameObject.GetComponent<Zombie>().health <= 0 && FightZone.wave3 && col.gameObject.GetComponent<Zombie>().isDead == false)
                {
                    Debug.Log("Fireball damage destroy enemy");
                    col.gameObject.GetComponent<Zombie>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.instance.fightZone3Enemies--;


                }
                if (col.gameObject.GetComponent<Zombie>().health <= 0 && FightZone.wave4 && col.gameObject.GetComponent<Zombie>().isDead == false)
                {
                    Debug.Log("Fireball damage destroy enemy");
                    col.gameObject.GetComponent<Zombie>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.instance.fightZone4Enemies--;


                }
            }

        }
    }
}
