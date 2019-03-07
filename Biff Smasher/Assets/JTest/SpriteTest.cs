using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpriteTesting : MonoBehaviour
{
    // player
    public GameObject player;
    public Text playerDialogueTextBox;

    //Orb
    public GameObject orb;
    public Text orbDialogueTextBox;

    public Text instructions;

    // pause length between dialogue
    public float timeBetweenText;

    // bool for can exit to first level
    public bool canExit;

    // scene name for sceneManager
    // scenes have to be in build settings "scenes to build" list
    public string level1 = "CamTest";

   

    // Use this for initialization
    void Start()
    {
        // start coroutine while update waits for key press
        StartCoroutine(ShowTextCo());

    }

    // Update is called once per frame
    void Update()
    {
        // go to level 1 on any key press
        if (canExit && Input.anyKeyDown)
        {
            SceneManager.LoadScene(level1);
        }
    }

    public IEnumerator ShowTextCo()
    {
        
        //Player
        // display for seconds
        yield return new WaitForSeconds(timeBetweenText);
        //hide character and dialogue box
        orbDialogueTextBox.gameObject.SetActive(false);
        orb.gameObject.SetActive(false);
        // text for dialogue box
        playerDialogueTextBox.text = "... And i'm all out of bubble gum. ";
        //Show character and dialogue box
        playerDialogueTextBox.gameObject.SetActive(true);
        player.gameObject.SetActive(true);

        // instructions
        // display for seconds
        yield return new WaitForSeconds(timeBetweenText);
        //  press any key bool set to true
        instructions.gameObject.SetActive(true);
        canExit = true;
    }
}
