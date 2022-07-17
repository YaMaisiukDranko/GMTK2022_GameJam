using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    //public event EventHandler OnPlayerStandOnFinalRoute;
    public GameObject GameOverUI;
    public Route currentRoute;

    public static int routePosition;

    public int steps;
    int stepToFinish;

    public static bool isMoving;
    private bool finalMove;
    
    private void Start()
    {
        //this.OnPlayerStandOnFinalRoute += Stone_OnPlayerStandOnFinalRoute;
        stepToFinish = currentRoute.childNodeList.Count - 2;
    }

    private void Stone_OnPlayerStandOnFinalRoute(object sender, EventArgs e)
    {
        //GameOverUI.Instance.Show();
        GameOverUI.SetActive(true);
        Debug.Log("Game Over!");
    }

    private void Update()
    {
        if (routePosition > 39)
        {
            GameOverUI.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            //Debug.Log("FigureMoving");
            if(!isMoving)
            { 
                steps = DiceNumberText.diceNumber;

                if (routePosition + steps < currentRoute.childNodeList.Count)
                {
                    StartCoroutine(Move());
                }
                else
                {
                    if(stepToFinish > 0)
                    {
                        steps = stepToFinish - 1;
                        finalMove = true;
                        StartCoroutine(Move());
                    }
                }
            }
        }    
    }

    public IEnumerator Move()
    {
        if (isMoving)
        {
            yield break;
        }
        isMoving = true;

        while (steps > 0)
        {
            Vector3 nextPos = currentRoute.childNodeList[routePosition + 1].position;

            int gameOverValue = currentRoute.childNodeList.Count - 1; //Game Over Platform

            while(MoveToNextNote(nextPos))
            {                
                yield return null;
            }

            yield return new WaitForSeconds(0.1f);

            Debug.Log($"Steps left: {steps - 1}");
            Debug.Log($"Steps to finish: {stepToFinish - routePosition}");
            
            steps--;
            routePosition++;     
        }

        isMoving = false;
    }

    private bool MoveToNextNote(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 8f * Time.deltaTime));
    }
}
