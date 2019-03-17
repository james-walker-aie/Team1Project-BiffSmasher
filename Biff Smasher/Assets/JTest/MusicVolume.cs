using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolume : MonoBehaviour
{

    // Reference to Audio Source component
    private AudioSource audioSrc;


    // Use this for initialization
    void Start()
    {

        // Assign Audio Source component to control it
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        // Setting volume option of Audio Source to be equal to volume set in Game Manager
        audioSrc.volume = GameManager.instance.musicVolume;
    }

}
