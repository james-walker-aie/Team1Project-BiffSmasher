using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageAttack : MonoBehaviour
{

    [SerializeField]
    GameObject fireball;

    
    public int damageToGive;

    
    float fireRate;
    float nextFire;

    private void Start()
    {
        fireRate = 2f;
        nextFire = Time.time;
    }

    private void Update()
    {
        CheckIfTimeToFire();
    }


    void CheckIfTimeToFire()
    {

        if (Time.time > nextFire)
        {
            Instantiate(fireball, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }

 

}
