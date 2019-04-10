using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UltimatePower : MonoBehaviour
{
    public static UltimatePower instance;
    public int ultimatePowerUpLevel;
    public int fireballCount;
    public int UltimatePowerActivateNumber;
    public Slider ultimateUI;
    public Text FireballText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // set ulimate slider
        SetUltimateUI();

        //set Fireball UI
        FireballText.text = fireballCount.ToString();

        if (ultimatePowerUpLevel >= UltimatePowerActivateNumber)
        {

            // Set fireball count to 3
            fireballCount = 3;
            
           
            // set ulimate variable to true in character controller
            CharacterController2D.instance.ultimate = true;
            //reset check
            ultimatePowerUpLevel = 0;
           

        }
        if (fireballCount <= 0)
        {
            CharacterController2D.instance.ultimate = false;
        }
    }

    public void SetUltimateUI()
    {

        ultimateUI.value = ultimatePowerUpLevel; //Update Slider's Value To Equal Player's Health
    }
}
