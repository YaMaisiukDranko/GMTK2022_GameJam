using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DiceScript : MonoBehaviour
{
    private static Rigidbody rb;
    public static Vector3 diceVelocity;
    public int diceNum;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); //Get RB
    }

    private void Update()
    {
        diceVelocity = rb.velocity;
        
        if(Input.GetKeyDown(KeyCode.R)) //Check for R Button Click
        {
            diceNum = 0;
            //Random rotation of Dice
            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(0, 500);

            transform.position = new Vector3(0, 10, 0);
            transform.rotation = Quaternion.identity;
            
            rb.AddForce(transform.up * -200); //Drop Dice
            rb.AddTorque(dirX, dirY, dirZ);
        }
        
    }
}
