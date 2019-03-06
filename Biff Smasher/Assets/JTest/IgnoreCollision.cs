using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{

   public GameObject enemy;
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
        //wall = GameObject.FindWithTag("FightZoneWall");
    }

    // Update is called once per frame
    void Update()
    {
        //ignore collision with enemy
        Physics2D.IgnoreCollision(enemy.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        //Physics2D.IgnoreCollision(wall.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
}
