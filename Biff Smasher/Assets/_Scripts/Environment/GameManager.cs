using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int fightZone1Enemies = 1;
    public int fightZone2Enemies = 1;
    public int fightZone3Enemies = 1;
    public int fightZone4Enemies = 1;
    public GameObject zone1Trigger;
    public GameObject zone2Trigger;
    public GameObject zone3Trigger;
    public GameObject zone4Trigger;
    public GameObject zone1wall;
    public GameObject zone2wall;
    public GameObject zone3wall;
    public GameObject zone4wall;
    public GameObject playerCam;

    public bool canPause = true;

    //level unlocked
    [SerializeField]
    private int level1;
    private int level2;
    private int level3;

    //Reference To Slider
    public Slider MusicSlider;
    public Slider SFXSlider;

    // Music volume variable that will be modified
    // by dragging music slider knob
    public float musicVolume = 1f;

    // SFX volume variable that will be modified
    // by dragging music slider knob
    public float sFXVolume = 1f;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // get volumelevel
        musicVolume = PlayerPrefs.GetFloat("Volume");
        MusicSlider.value = musicVolume; //Update Slider's Value To Equal volume level

        // get SFXvolumelevel
        sFXVolume = PlayerPrefs.GetFloat("SFXVolume");
        SFXSlider.value = musicVolume; //Update Slider's Value To Equal volume level

        // see if level is unlocked
        level1 = PlayerPrefs.GetInt("level1");
        level2 = PlayerPrefs.GetInt("level2");
        level3 = PlayerPrefs.GetInt("level3");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && canPause)
        {
            PauseUnpause();
        }

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

                //music
                MusicManager.instance.PlayLevel1();
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

                //music
                MusicManager.instance.PlayLevel1();

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

                //music
                MusicManager.instance.PlayLevel1();

            }
        }

        if (FightZone.wave4 == true)
        {
            //  Debug.Log("Wave 4");
            if (fightZone4Enemies <= 0)
            {
                zone4wall.SetActive(false);
                playerCam.SetActive(true);

                FightZone.wave4 = false;
                Debug.Log("Wave 4 defeated");

                //music
                MusicManager.instance.PlayVictory();

            }
        }
    }
    public void PauseUnpause()
    {

        if (UIManager.instance.pauseScreen.activeInHierarchy)
        {
            Debug.Log("PauseMenu Inactive");
            UIManager.instance.pauseScreen.SetActive(false);
            Time.timeScale = 1f;
            //  PlayerController.instance.StopMove = false;
        }
        else
        {
            Debug.Log("PauseMenu active");
            UIManager.instance.pauseScreen.SetActive(true);
            Time.timeScale = 0f;
            // PlayerController.instance.StopMove = true;
        }
    }

    // Method that is called by Music slider UI
    // This method takes vol value passed by slider
    // and sets it as musicVolume
    public void SetVolume(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat("Volume", musicVolume);
    }

    public void SFXSetVolume(float vol)
    {
       sFXVolume = vol;
        PlayerPrefs.SetFloat("SFXVolume", sFXVolume);
    }
}
