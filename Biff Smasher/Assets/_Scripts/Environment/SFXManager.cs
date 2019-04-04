using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    // make an instance of the script for refering in other scripts
    public static SFXManager instance;
    // Music
    public AudioSource fireball, punch, swordAxeSwing, kick;
    public AudioSource playerDying;
    public AudioSource enemyDying;
    public AudioSource portalOpen;
    public AudioSource portalDeath;

    private void Awake()
    {
        instance = this;
    }


    // Use this for initialization
    void Start()
    {
        // MainMenuMusic.Play();
    }



    public void StopSFX()
    {
        /*
        fireball.Stop();
        punch.Stop();
        swordAxeSwing.Stop();
        kick.Stop();
        playerDying.Stop();
        enemyDying.Stop();
        */
    }

    public void Fireball()
    {
        //StopMusic();
        fireball.Play();
    }
    public void Punch()
    {
        // StopMusic();
        punch.Play();
    }
    public void SwordAxeSwing()
    {
        // StopMusic();
        swordAxeSwing.Play();
    }

    public void Kick()
    {
        // StopMusic();
        kick.Play();
    }

    public void PlayerDying()
    {
        // StopMusic();
        playerDying.Play();
    }

    public void EnemyDying()
    {
        // StopMusic();
        enemyDying.Play();
    }


}
