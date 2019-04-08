using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMage : MonoBehaviour
{

    public Vector2 startDirection;
    Transform player;
    public float moveSpeed;
    public int fBdamageToZombie;

    public int attackDamage;

    // public Rigidbody2D MyRB;

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

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
        if (startDirection.x >= 0)
        {
            // flip x axis to right
            Vector3 theScale = transform.localScale;
            theScale.x = 1;
            transform.localScale = theScale;

            // Debug.Log("x value " + startDirection.x);
            // speed and direction 
            transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);

        }
        else
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

 

                if (col.gameObject.CompareTag("Player") && Health.instance.currentHealth > 0)
                {

                    Health.instance.currentHealth -= attackDamage;
                    Debug.Log(" hit player" + Health.instance.currentHealth);
                }
                // knockback direction
                // Vector2 hitDir = col.transform.position - this.transform.position;
                // hitDir = hitDir.normalized;
                //  col.gameObject.GetComponent<Zombie>().Knockback(hitDir);

       

   



    }
}
