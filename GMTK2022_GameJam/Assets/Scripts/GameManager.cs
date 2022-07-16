using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject SpaceButton;
    [SerializeField] private GameObject RButton;
    public enum CharacterState { Player, Enemy1, Enemy2 } 
    public enum MoveState { PlayerMove, Enemy1Move, Enemy2Move, NobodyMove }

    private void Start()
    {
        RButton.SetActive(true);
        SpaceButton.SetActive(false);
    }

    private void Update()
    {
        if()
    }
}
