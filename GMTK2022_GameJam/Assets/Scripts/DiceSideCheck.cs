using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSideCheck : MonoBehaviour
{
    private Vector3 diceVelocity;
    public int diceNumber;
    private Stone _stone;

    private void Start()
    {
        DiceNumberText.diceNumber = diceNumber;
        _stone = GameObject.FindWithTag("Player").GetComponent<Stone>();
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
                        DiceNumberText.diceNumber = 3;
                        break;
                    case "Side2":
                        DiceNumberText.diceNumber = 4;
                        break;
                    case "Side3":
                        DiceNumberText.diceNumber = 1;
                        break;
                    case "Side4":
                        DiceNumberText.diceNumber = 2;
                        break;
                    case "Side5":
                        DiceNumberText.diceNumber = 6;
                        break;
                    case "Side6":
                        DiceNumberText.diceNumber = 5;
                        break;
            }

            //Call figure moving
            if (DiceNumberText.diceNumber != 0)
            {
                //_stone.FigureMoving();
            }
            
        }
    }
}
