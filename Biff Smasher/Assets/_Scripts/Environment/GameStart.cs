using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // set initial game volume and SFX
        PlayerPrefs.SetFloat("Volume", 1);
    
        PlayerPrefs.SetFloat("SFXVolume", 1);
    }


}
