using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{

    public int damageToZombie = 10;
    public int damageToMage = 20;
    public int damageToKnight = 30;

    public GameObject damageBust;
    public Transform bloodHit;
    public AudioSource hitSound;

    private void Start()
    {
        hitSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Zombie")
        {
            other.gameObject.GetComponent<ZombieHealth>().HurtEnemy(damageToZombie);
            Instantiate(damageBust, bloodHit.position, bloodHit.rotation);
            hitSound.Play();
                        
        }

        if (other.gameObject.tag == "Knight")
        {
            other.gameObject.GetComponent<KnightHealth>().HurtEnemy(damageToKnight);
            Instantiate(damageBust, bloodHit.position, bloodHit.rotation);
            hitSound.Play();

        }

        if (other.gameObject.tag == "Mage")
        {
            other.gameObject.GetComponent<MageHealth>().HurtEnemy(damageToMage);
            Instantiate(damageBust, bloodHit.position, bloodHit.rotation);
            hitSound.Play();

        }

    }

   


}
