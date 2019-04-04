﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightZone : MonoBehaviour
{

    public static FightZone instance;
    public GameObject player;
    public GameObject enemySpawn;
  //  public GameObject enemy;
    public GameObject fightZoneCollider;
    public GameObject zoneWallFront, zoneWallBehind;


    // cams
    public GameObject playerCam;
    public GameObject FightZoneCam;


    // waves
    public bool w1;
    public bool w2;
    public bool w3;
    public bool w4;
    public static bool wave1;
    public static bool wave2;
    public static bool wave3;
    public static bool wave4;

    //Enemy spwan enabled
    

    // set spawn delay
    public float timeBetweenSpawn;

    // Set static variables
    void Awake()
    {
        instance = this;
        wave1 = w1;
        //  wave2 = w2;
        //  wave3 = w3;
        // wave4 = w4;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("OnCollisionEnter2D");
        if (other.gameObject.CompareTag("Player") && wave1 == true)
        {
            Debug.Log("FightZone1 collider Active");
            // camera swap to fight cam
            FightZoneCam.SetActive(true);
            playerCam.SetActive(false);

            // start spawning of enemies script
            enemySpawn.GetComponent<SpawnEnemies>().enabled = true;





            // Music
            MusicManager.instance.PlayFight();

            // set walls for fight zone
            zoneWallFront.SetActive(true);
            zoneWallBehind.SetActive(true);
            Debug.Log("FightZone1 Walls Active");

            // spawn enemy
           // Instantiate(enemy, enemySpawn.transform.position, Quaternion.identity);

            Destroy(gameObject);
        }


        if (other.gameObject.tag == "Player" && wave2 == true)
        {
            Debug.Log("FightZone2 collider Active");
            // camera swap to fight cam
            FightZoneCam.SetActive(true);
            playerCam.SetActive(false);

            // Music
            MusicManager.instance.PlayFight();

            // set walls for fight zone
            zoneWallFront.SetActive(true);
            zoneWallBehind.SetActive(true);
            Debug.Log("FightZone2 Walls Active");

            // start spawning of enemies script
            enemySpawn.GetComponent<SpawnEnemies>().enabled = true;

            Destroy(gameObject);
        }


        if (other.gameObject.tag == "Player" && wave3 == true)
        {
            Debug.Log("FightZone3 collider Active");
            // camera swap to fight cam
            FightZoneCam.SetActive(true);
            playerCam.SetActive(false);

            // Music
            MusicManager.instance.PlayFight();


            // set walls for fight zone
            zoneWallFront.SetActive(true);
            zoneWallBehind.SetActive(true);
            Debug.Log("FightZone3 Walls Active");

            // start spawning of enemies script
            enemySpawn.GetComponent<SpawnEnemies>().enabled = true;

            Destroy(gameObject);
        }


        if (other.gameObject.tag == "Player" && wave4 == true)
        {
            Debug.Log("FightZone4 collider Active");
            // camera swap to fight cam
            FightZoneCam.SetActive(true);
            playerCam.SetActive(false);

            // Music
            MusicManager.instance.PlayFight();


            // set walls for fight zone
            zoneWallFront.SetActive(true);
            zoneWallBehind.SetActive(true);
            Debug.Log("FightZone4 Walls Active");

            // start spawning of enemies script
            enemySpawn.GetComponent<SpawnEnemies>().enabled = true;
            // spawn enemy
           // Instantiate(enemy, enemySpawn.transform.position, Quaternion.identity);

            Destroy(gameObject);
        }


    }



}
