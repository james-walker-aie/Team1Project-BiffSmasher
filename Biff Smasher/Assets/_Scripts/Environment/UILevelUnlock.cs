using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UILevelUnlock : MonoBehaviour
{

    // button covers
    public GameObject lvl2Cover;
    public GameObject lvl3Cover;


    public void Start()
    {
        if (GameManager.instance.level2 >= 1)
        {
            // hide level2 cover
            lvl2Cover.SetActive(false);
        }

        if (GameManager.instance.level3 >= 1)
        {
            // hide level2 cover
            lvl3Cover.SetActive(false);
        }
    }
}
