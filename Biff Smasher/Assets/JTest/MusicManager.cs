using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // make an instance of the script for refering in other scripts
    public static MusicManager instance;
    // Music
    public AudioSource MainMenuMusic, FightMusic, level1Music, level2Music, level3Music, bossMusic, victoryMusic, gameOverMusic;

    private void Awake()
    {
        instance = this;
    }


    // Use this for initialization
    void Start()
    {
       // MainMenuMusic.Play();
    }



    public void StopMusic()
    {
        MainMenuMusic.Stop();
        FightMusic.Stop();
        level1Music.Stop();
       // level2Music.Stop();
      //  level3Music.Stop();
     //   bossMusic.Stop();
        victoryMusic.Stop();
       // gameOverMusic.Stop();
    }

    public void PlayLevel1()
    {
        StopMusic();
        level1Music.Play();
    }
    public void PlayLevel2()
    {
        StopMusic();
        level2Music.Play();
    }
    public void PlayLevel3()
    {
        StopMusic();
        level3Music.Play();
    }

    public void PlayFight()
    {
        StopMusic();
        FightMusic.Play();
    }

    public void PlayBoss()
    {
        StopMusic();
        bossMusic.Play();
    }

    public void PlayVictory()
    {
        StopMusic();
        victoryMusic.Play();
    }

    public void PlayGameOver()
    {
        StopMusic();
        gameOverMusic.Play();
    }
}
