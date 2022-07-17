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
    public GameObject MemePanel;
    private void Start()
    {
        RButton.SetActive(true);
        SpaceButton.SetActive(false);
        cState = CharacterState.Player;
        mState = MoveState.NobodyMove;
    }

    private void Update()
    {
        int currentStep = MemeManager.currentStep;
        bool isMoving = MemeManager.isMoving;
        if (currentStep >= 1)
        {
            if (isMoving == true && DiceNumberText.diceNumber > 1)
            {
                
                //SecondCamera.SetActive(false);
                MemePanel.SetActive(false);
                
            }
            else if(isMoving == false && DiceNumberText.diceNumber > 1)
            {
                
                //SecondCamera.SetActive(true);
                MemePanel.SetActive(true);
                
            }
            else if(DiceNumberText.diceNumber == 1)
            {
                //SecondCamera.SetActive(false);
                MemePanel.SetActive(false);
            }
        }
        else
        {
            
        }
        
    }

    public void OnClickYes()
    {
        Debug.Log("CLOSE");
        MemePanel.gameObject.SetActive(false);
    }
    public void OnClickNo()
    {
        Debug.Log("CLOSE");
        MemePanel.SetActive(false);
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
