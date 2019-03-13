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
         startDirection.x = transform.position.x - player.position.x ;
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
                if (col.gameObject.GetComponent<EnemyMovement>().health > 0 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("Fireball damage current health " + col.gameObject.GetComponent<EnemyMovement>().health);
                    col.gameObject.GetComponent<EnemyMovement>().FireballDamage();
                    Debug.Log("Fireball damage hurt enemy " + col.gameObject.GetComponent<EnemyMovement>().health);

                    // knockback direction
                    Vector2 hitDir = col.transform.position - this.transform.position;
                    hitDir = hitDir.normalized;
                    col.gameObject.GetComponent<EnemyMovement>().Knockback(hitDir);

                }

                if (col.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave1 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("Fireball damage destroy enemy");
                    col.gameObject.GetComponent<EnemyMovement>().isDead = true;
                    GameManager.fightZone1Enemies--;
                    Destroy(col.gameObject, .1f);

                }

                if (col.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave2 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("Fireball damage destroy enemy");
                    col.gameObject.GetComponent<EnemyMovement>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.fightZone2Enemies--;


                }
                if (col.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave3 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("Fireball damage destroy enemy");
                    col.gameObject.GetComponent<EnemyMovement>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.fightZone3Enemies--;


                }
                if (col.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave4 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("Fireball damage destroy enemy");
                    col.gameObject.GetComponent<EnemyMovement>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.fightZone4Enemies--;


                }
            }

        }
    }
}
