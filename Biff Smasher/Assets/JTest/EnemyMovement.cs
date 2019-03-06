using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    // simple move left script
    public float moveSpeed;

    public Vector2 startDirection;

    

    // Navmesh
    // NavMeshAgent agent;

    // Player
  //  public Transform target;

    //Health
    public float health = 2;



    public Vector3 moveDir;
   //  public float[] myArray;

    // rigidbody
  //  public Rigidbody2D rb;




    // Start is called before the first frame update
    void Start()
    {
        // AI find navmesh
       // agent = this.GetComponent<NavMeshAgent>();
        // on Instantiation Ai will find player and Set as target
     //  target = GameObject.Find("Capsule").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // simple move script
        transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
      
    }


   public void Movement()
    {
        // move the enemy get values from array
        //  this.transform.forward = new Vector3(myArray[0], myArray[1], myArray[2])  * 1000f;
      //  rb.AddForce(moveDir.x, moveDir.y,moveDir.z, ForceMode.Impulse);

    }
    /*
    public void Health()
    {
        health--;
    }
    */
    /*
    public void Knockback(Vector3 dir)
    {
        knockbackCounter = knockbackTime;
        //turn off NavAgent script
     //   agent.enabled = false;

        //calculate move enemy values
       moveDir = dir * knockbackForce;
        moveDir.y = knockbackForce;
        moveDir.z = 0;

    }
    */
}
