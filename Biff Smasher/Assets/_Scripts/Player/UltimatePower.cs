using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimatePower : MonoBehaviour
{
    public static UltimatePower instance;
    public int ultimatePowerUpLevel;
    public int fireballCount;
    public int UltimatePowerActivateNumber;


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
        if (ultimatePowerUpLevel >= UltimatePowerActivateNumber)
        {
            // set UI

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
}
