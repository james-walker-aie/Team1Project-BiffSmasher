using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOrbAttack : MonoBehaviour
{
    [SerializeField]
    GameObject fireball;

    public int damageToGive;


    float fireRate;
    float nextFire;

    private void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }

    private void Update()
    {

    }

    public void CheckIfTimeToFire()
    {

        if (Time.time > nextFire)
        {
            Instantiate(fireball, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
