using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRetreatAndAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    public Transform Waypoint;
    GameObject player;
    
    float timer; 


    // Start is called before the first frame update
    void Start()
    {
        Waypoint = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Waypoint.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Waypoint.position, speed * Time.deltaTime); 
        }  

        else if(Vector2.Distance(transform.position, Waypoint.position) < stoppingDistance && Vector2.Distance(transform.position, Waypoint.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }

        else if(Vector2.Distance(transform.position, Waypoint.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Waypoint.position, -speed * Time.deltaTime);
        }

    }

   
}
