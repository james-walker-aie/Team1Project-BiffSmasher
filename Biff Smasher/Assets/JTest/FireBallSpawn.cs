using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSpawn : MonoBehaviour
{
    public GameObject fireBallSpawn;
    public GameObject fireBall;
    public bool spawned;
    public float cooldown;
    public float cooldownTime = .1f;
    private void Start()
    {
        
    }
    void Update()
    {
        if(spawned == false)
        {
            // spawn Fireball
            Instantiate(fireBall, fireBallSpawn.transform.position, Quaternion.identity);
            spawned = true;
           // fireBallSpawn.SetActive(false); 
        }
        
        else
        {
            cooldown -= Time.deltaTime;
        }
        if (cooldown <= 0)
        {
            spawned = false;
            cooldown = cooldownTime;
        }
        
    }

    
}
