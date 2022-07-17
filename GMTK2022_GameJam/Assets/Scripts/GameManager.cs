using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject SpaceButton;
    [SerializeField] private GameObject RButton;
    [SerializeField] private GameObject GOUI;
    public enum CharacterState { Player, Enemy1, Enemy2 } 
    public enum MoveState { PlayerMove, Enemy1Move, Enemy2Move, NobodyMove }
    CharacterState cState;
    private MoveState mState;
    private DiceScript DS;
    public GameObject Dice;
    private void Start()
    {
        RButton.SetActive(true);
        SpaceButton.SetActive(false);
        cState = CharacterState.Player;
        mState = MoveState.NobodyMove;
    }

    private void Update()
    {
        FirstDiceDrop();
        //CHARACTER STATE CHECK
        if (cState == CharacterState.Player)
        {
            
        }
        else if (cState == CharacterState.Enemy1)
        {
            
        }
        else if(cState == CharacterState.Enemy2)
        {
            
        }

        //MOVEMENT STATE CHECK
        if (mState == MoveState.PlayerMove)
        {
            //SpaceButton.S
        }
        else if(mState == MoveState.Enemy1Move)
        {
             
        }
        else if(mState == MoveState.Enemy2Move)
        {
             
        }
        else if(mState == MoveState.NobodyMove)
        {
             
        }
        
    }

    public void FirstDiceDrop()
    {
        if (Input.GetKeyDown(KeyCode.R) && MemeManager.diceDropped == false) //Check for R Button Click
        {
            Instantiate(Dice, new Vector3(-2.7f, 27.4f, 4.7f), Quaternion.identity);
            DS.DropDice();
        }
    }
    
    
    void PlayingOrder()
    {
        
    }

    void OnClickSpace()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("GAMEOVER");
            GOUI.SetActive(true);
        }
    }
    
}
