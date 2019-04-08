using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{

    public GameObject enemySpawn;
    public GameObject[] enemiesZ1;
    public GameObject[] enemiesZ2;
    public GameObject[] enemiesZ3;
    public GameObject[] enemiesZ4;

    public bool stopSpawn;
    public int rNDEnemies;
    public int enemyCount;

    // random variables
    public float spawnWait;

    // level spawn trigger bools
    
    public bool z1;
    public bool z2;
    public bool z3;
    public bool z4;

    // enemy numbers to spawn

        public int spawn1, spawn2, spawn3, spawn4;


    private void Awake()
    {
       
    }

    private void Start()


    {
        spawn1 = GameManager.instance.fightZone1Enemies;
        spawn2 = GameManager.instance.fightZone2Enemies;
        spawn3 = GameManager.instance.fightZone3Enemies;
        spawn4 = GameManager.instance.fightZone4Enemies;

        StartCoroutine(SpawnTheEnemies());
    }
    // Update is called once per frame
    void Update()
    {
        if (z1)
        {
            if (enemyCount >= spawn1)
            {
                Debug.Log("Stop spawn");
                stopSpawn = true;
                // stop spawning of enemies script
                enemySpawn.GetComponent<SpawnEnemies>().enabled = false;
            }
            else
            {
                Debug.Log("Spawn enemy");
                spawnWait = Random.Range(1, 2);
            }
        }

        if (z2)
        {
            if (enemyCount >= spawn2)
            {
                Debug.Log("Stop spawn");
                stopSpawn = true;
                // stop spawning of enemies script
                enemySpawn.GetComponent<SpawnEnemies>().enabled = false;
            }
            else
            {
                Debug.Log("Spawn enemy");
                spawnWait = Random.Range(1, 2);
            }
        }

        if (z3)
        {
            if (enemyCount >= spawn3)
            {
                Debug.Log("Stop spawn");
                stopSpawn = true;
                // stop spawning of enemies script
                enemySpawn.GetComponent<SpawnEnemies>().enabled = false;
            }
            else
            {
                Debug.Log("Spawn enemy");
                spawnWait = Random.Range(1, 2);
            }
        }

        if (z4)
        {
            if (enemyCount >= spawn4)
            {
                Debug.Log("Stop spawn");
                stopSpawn = true;
                // stop spawning of enemies script
                enemySpawn.GetComponent<SpawnEnemies>().enabled = false;
            }
            else
            {
                Debug.Log("Spawn enemy");
                spawnWait = Random.Range(1, 2);
            }
        }



    }
    IEnumerator SpawnTheEnemies()
    {
        // zone-1
        if(z1)
        while (stopSpawn == false )
        {
            yield return new WaitForSeconds(spawnWait);
            Debug.Log("Spawn enemy CR");
            // spawn random enemy
            rNDEnemies = Random.Range(0, enemiesZ1.Length);
            Instantiate(enemiesZ1[rNDEnemies], enemySpawn.transform.position, Quaternion.identity);
            enemyCount++; // keep of how many enemies spawned
            yield return new WaitForSeconds(spawnWait);
        }

        // zone-2
        if (z2)
            while (stopSpawn == false)
            {
                yield return new WaitForSeconds(spawnWait);
                Debug.Log("Spawn enemy CR");
                // spawn random enemy
                rNDEnemies = Random.Range(0, enemiesZ2.Length);
                Instantiate(enemiesZ2[rNDEnemies], enemySpawn.transform.position, Quaternion.identity);
                enemyCount++; // keep of how many enemies spawned
                yield return new WaitForSeconds(spawnWait);
            }

        // zone-3
        if (z3)
            while (stopSpawn == false)
            {
                yield return new WaitForSeconds(spawnWait);
                Debug.Log("Spawn enemy CR");
                // spawn random enemy
                rNDEnemies = Random.Range(0, enemiesZ3.Length);
                Instantiate(enemiesZ3[rNDEnemies], enemySpawn.transform.position, Quaternion.identity);
                enemyCount++; // keep of how many enemies spawned
                yield return new WaitForSeconds(spawnWait);
            }

        // zone-4
        if (z4)
            while (stopSpawn == false)
            {
                yield return new WaitForSeconds(spawnWait);
                Debug.Log("Spawn enemy CR");
                // spawn random enemy
                rNDEnemies = Random.Range(0, enemiesZ4.Length);
                Instantiate(enemiesZ4[rNDEnemies], enemySpawn.transform.position, Quaternion.identity);
                enemyCount++; // keep of how many enemies spawned
                yield return new WaitForSeconds(spawnWait);
            }
    }
}

