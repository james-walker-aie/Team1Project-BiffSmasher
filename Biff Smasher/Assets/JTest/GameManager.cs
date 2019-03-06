using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int fightZone1Enemies = 1;
    public static int fightZone2Enemies = 1;
    public static int fightZone3Enemies = 1;
    public static int fightZone4Enemies = 1;
    public GameObject zone1Trigger;
    public GameObject zone2Trigger;
    public GameObject zone3Trigger;
    public GameObject zone4Trigger;
    public GameObject zone1wall;
    public GameObject zone2wall;
    public GameObject zone3wall;
    public GameObject zone4wall;
    public GameObject playerCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (FightZone.wave1 == true)
        {
           // Debug.Log("Wave 1");
            if (fightZone1Enemies <= 0)
            {
                zone1wall.SetActive(false);
                playerCam.SetActive(true);
                zone2Trigger.SetActive(true);
                FightZone.wave1 = false;
                FightZone.wave2 = true;
                Debug.Log("Wave 1 defeated");
            }
        }

        if (FightZone.wave2 == true)
        {
         //   Debug.Log("Wave 2");
            if (fightZone2Enemies <= 0)
            {
                zone2wall.SetActive(false);
                playerCam.SetActive(true);
                zone3Trigger.SetActive(true);
                FightZone.wave2 = false;
                FightZone.wave3 = true;
                Debug.Log("Wave 2 defeated");
            }
        }

        if (FightZone.wave3 == true)
        {
          //  Debug.Log("Wave 3");

            if (fightZone3Enemies <= 0)
            {
                zone3wall.SetActive(false);
                playerCam.SetActive(true);
                zone4Trigger.SetActive(true);
                FightZone.wave3 = false;
                FightZone.wave4 = true;
                Debug.Log("Wave 3 defeated");
            }
        }

        if (FightZone.wave4 == true)
        {
          //  Debug.Log("Wave 4");
            if (fightZone4Enemies <= 0)
            {
                zone4wall.SetActive(false);
                playerCam.SetActive(true);

                // FightZone.wave4 = false;
                Debug.Log("Wave 4 defeated");
            }
        }
    }
}
