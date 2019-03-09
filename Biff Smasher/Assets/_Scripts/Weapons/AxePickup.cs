using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxePickup : MonoBehaviour
{
    CharacterController2D controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController2D>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            controller.axe = true;
            Destroy(gameObject);

        }
    }

}
