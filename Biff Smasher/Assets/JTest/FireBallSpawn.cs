using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSpawn : MonoBehaviour
{
    public GameObject fireBallSpawn;
    public GameObject fireBall;
    
   void Start()
    {
        // spawn Fireball
        Instantiate(fireBall, fireBallSpawn.transform.position, Quaternion.identity);
    }

    
}
