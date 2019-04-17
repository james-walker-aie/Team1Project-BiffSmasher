using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TransitionA : MonoBehaviour
{
    // player
    [SerializeField] GameObject player;
    [SerializeField] Text playerDialogueTextBox;

    //Orb
    [SerializeField] GameObject orb;
    [SerializeField] Text orbDialogueTextBox;
    [SerializeField] Animator animator;
    [SerializeField] Text instructions;

    // pause length between dialogue
    [SerializeField] float timeBetweenText;

    // bool for can exit to first level
    [SerializeField] bool canExit;

    // scene name for sceneManager
    // scenes have to be in build settings "scenes to build" list
    [SerializeField] string level1 = "CamTest";

   

    // Use this for initialization
    void Start()
    {
        if (GameManager.instance.level2 <=0)
        {
            PlayerPrefs.SetInt("level2", 1);
        }
        // start coroutine while update waits for key press
        StartCoroutine(ShowTextCo());

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetTrigger("Talking");
        // go to level 1 on any key press
        if (canExit && Input.anyKeyDown)
        {
            SceneManager.LoadScene(level1);
        }
    }

    public IEnumerator ShowTextCo()
    {
        // opening dialogue with player and orb

        //player
        // display for seconds
        yield return new WaitForSeconds(timeBetweenText);
        //hide character and dialogue box
        orbDialogueTextBox.gameObject.SetActive(false);
        orb.gameObject.SetActive(false);
        // text for dialogue box
        playerDialogueTextBox.text = "Phew, where are we now?";
        //Show character and dialogue box
        playerDialogueTextBox.gameObject.SetActive(true);
        player.gameObject.SetActive(true);

        //Orb
        // display for seconds
        yield return new WaitForSeconds(timeBetweenText);
        //hide character and dialogue box
        playerDialogueTextBox.gameObject.SetActive(false);
        player.gameObject.SetActive(false);
        // text for dialogue box
        orbDialogueTextBox.text = "The village of lost souls.";
        //Show character and dialogue box
        orbDialogueTextBox.gameObject.SetActive(true);
        orb.gameObject.SetActive(true);

        //Player
        // display for seconds
        yield return new WaitForSeconds(timeBetweenText);
        //hide character and dialogue box
        orbDialogueTextBox.gameObject.SetActive(false);
        orb.gameObject.SetActive(false);
        // text for dialogue box
        playerDialogueTextBox.text = "Let me guess, I have to fight my way through.";
        //Show character and dialogue box
        playerDialogueTextBox.gameObject.SetActive(true);
        player.gameObject.SetActive(true);

        //Orb
        // display for seconds
        yield return new WaitForSeconds(timeBetweenText);
        //hide character and dialogue box
        playerDialogueTextBox.gameObject.SetActive(false);
        player.gameObject.SetActive(false);
        // text for dialogue box
        orbDialogueTextBox.text = "Yes, the exit back to your world is past the castle not far from here.";
        //Show character and dialogue box
        orbDialogueTextBox.gameObject.SetActive(true);
        orb.gameObject.SetActive(true);

        //Player
        // display for seconds
        yield return new WaitForSeconds(timeBetweenText);
        //hide character and dialogue box
        orbDialogueTextBox.gameObject.SetActive(false);
        orb.gameObject.SetActive(false);
        // text for dialogue box
        playerDialogueTextBox.text = "Well, lets smash through the evil then!";
        //Show character and dialogue box
        playerDialogueTextBox.gameObject.SetActive(true);
        player.gameObject.SetActive(true);



        //Player
        // display for seconds
        yield return new WaitForSeconds(timeBetweenText);
        //hide character and dialogue box
        orbDialogueTextBox.gameObject.SetActive(false);
        orb.gameObject.SetActive(false);
        // text for dialogue box
        playerDialogueTextBox.text = "... I've got dinner at 7 and I ain't missing out.";
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
