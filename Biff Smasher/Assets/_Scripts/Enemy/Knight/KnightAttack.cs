using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAttack : MonoBehaviour
{
    public int damageToGive;
    public GameObject damageBust;
    public Transform knightHit;
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
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Health>().HurtPlayer(damageToGive);
            Instantiate(damageBust, knightHit.position, knightHit.rotation);
            hitSound.Play();


        }
    }
}
