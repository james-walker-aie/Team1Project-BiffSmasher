using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoRight : MonoBehaviour
{
    public Image goRight;
    public Text instruct;

    private void OnTriggerEnter2D(Collider2D col)
    {
            if(col.gameObject.tag == "Player")
        {
            // show go right arrow
            goRight.enabled = true;
            instruct.enabled = true;
        }
    }
     


    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            // Hide go right arrow
            goRight.enabled = false;
            instruct.enabled = false;
        }
    }
}
