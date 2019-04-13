using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    /*
    public int damageToZombie = 10;
    public int damageToMage = 20;
    public int damageToKnight = 30;
    public int damageToGuardian = 30;
    */

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
        if(other.gameObject.tag == "Zombie" )
        {
            if(other.gameObject.GetComponent<ZombieHealth>().isDead == false)
            {
                other.gameObject.GetComponent<ZombieHealth>().HurtEnemy(CharacterController2D.instance.weaponDamage);
                Instantiate(damageBust, bloodHit.position, bloodHit.rotation);
                hitSound.Play();
            }

   

        }

        if (other.gameObject.tag == "Knight")
        {
            if(other.gameObject.GetComponent<KnightHealth>().isDead == false)
            {
                other.gameObject.GetComponent<KnightHealth>().HurtEnemy(CharacterController2D.instance.weaponDamage);
                Instantiate(damageBust, bloodHit.position, bloodHit.rotation);
                hitSound.Play();
            }
        
    
        }

        if (other.gameObject.tag == "Mage")
        {
            if(other.gameObject.GetComponent<MageHealth>().isDead == false)
            {
                other.gameObject.GetComponent<MageHealth>().HurtEnemy(CharacterController2D.instance.weaponDamage);
                Instantiate(damageBust, bloodHit.position, bloodHit.rotation);
                hitSound.Play();
            }
          
        }

        if (other.gameObject.tag == "Guardian")
        {
            other.gameObject.GetComponent<GuardianHealth>().HurtEnemy(CharacterController2D.instance.weaponDamage);
            Instantiate(damageBust, bloodHit.position, bloodHit.rotation);
            hitSound.Play();
        }
    }

}
