﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // make an instance of the script for refering in other scripts
    public static UIManager instance;

    //Game Over UI
    public GameObject gameOverScreen;

    // UI Player information
    public Text LivesText;

    public Slider healthBar;
    /*
    // maybe running score
    public Text scoreText, hiScore;

    // level end results
    public GameObject levelEndScreen;
    // score for level and cumilative score
    public Text endLevelScore, endCurrentScore;
    // show new high score notice if needed
    public GameObject highScoreNotice;
    */

    // pause menu
    public GameObject pauseScreen;


    // main menu scene if player quits from level
    public string mainMenuName = "Menu";
    // Prologue scene if player clicks play
    public string PrologueName = "Prologue";
    // Credits scene if player clicks credits
    public string CreditsName = "Credits";
    // Level2 scene if player clicks level2
    public string Level2Name = "level2";
    // Level3 scene if player clicks level3
    public string Level3Name = "level3";



    //Boss health bar
    public Slider boosHealthSlider;
    public Text bossName;

    private void Awake()
    {
        instance = this;
    }



    public void ExitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void QuitToMain()
    {
        //Application.Quit();
        SceneManager.LoadScene(mainMenuName);
        Time.timeScale = 1;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(PrologueName);
        Time.timeScale = 1;
    }

    public void Resume()
    {
        GameManager.instance.PauseUnpause();
    }

    public void Credits()
    {
        SceneManager.LoadScene(CreditsName);
        Time.timeScale = 1;
    }

    public void Level2()
    {
        SceneManager.LoadScene(Level2Name);
        Time.timeScale = 1;
    }

    public void Level3()
    {
        SceneManager.LoadScene(Level3Name);
        Time.timeScale = 1;
    }
}
