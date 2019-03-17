using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickups : MonoBehaviour
{
    //Weapons
    public bool isAxe;
    public bool isSword;
    public bool isBranch;

    // Spawn movement
    public float up;
    public float sideways;
    public Vector2 moveDir;
    public float spawnCounter, spawnTime;


    CharacterController2D controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController2D>();
        spawnCounter = spawnTime;
    }

    private void Update()
    {
        //movement
        if(spawnCounter > 0)
        {
            //simple spawn toss
            transform.position += new Vector3(moveDir.x * sideways * Time.deltaTime, moveDir.y * up * Time.deltaTime, 0f);
            spawnCounter -= Time.deltaTime;
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
       
    }

    public void ResetWeaponController()
    {
        controller.axe = false;
        controller.sword = false;
        controller.branch = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && isAxe == true)
        {
            ResetWeaponController();
            controller.axe = true;
        }
        if (other.CompareTag("Player") && isSword == true)
        {
            ResetWeaponController();
            controller.sword = true;
        }
        if (other.CompareTag("Player") && isBranch == true)
        {
            ResetWeaponController();
            controller.branch = true;
        }

        Destroy(gameObject);
    }
}
