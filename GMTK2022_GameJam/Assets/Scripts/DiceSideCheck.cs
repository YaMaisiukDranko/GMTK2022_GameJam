using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSideCheck : MonoBehaviour
{
    private Vector3 diceVelocity;
    public int diceNumber;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        diceVelocity = DiceScript.diceVelocity;
    }

    private void OnTriggerStay(Collider col)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f) //Checking Dice Side
        {
            switch (col.gameObject.name)
            {
                case "Side1":
                    DiceScript.diceNum = 6;
                    break;
                case "Side2":
                    DiceScript.diceNum = 5;
                    break;
                case "Side3":
                    DiceScript.diceNum = 4;
                    break;
                case "Side4":
                    DiceScript.diceNum = 3;
                    break;
                case "Side5":
                    DiceScript.diceNum = 2;
                    break;
                case "Side6":
                    DiceScript.diceNum = 1;
                    break;
            }
        }
    }
}
