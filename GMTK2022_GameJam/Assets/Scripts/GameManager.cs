using System;
using System.Collections;
using System.Collections.Generic;
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
    private void Start()
    {
        RButton.SetActive(true);
        SpaceButton.SetActive(false);
        cState = CharacterState.Player;
        mState = MoveState.NobodyMove;
    }

    private void Update()
    {
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

    void PlayingOrder()
    {
        
    }

    void OnClickSpace()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GOUI.SetActive(true);
        }
    }
}
