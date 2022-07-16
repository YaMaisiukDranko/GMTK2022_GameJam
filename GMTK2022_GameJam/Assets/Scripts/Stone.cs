using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public event EventHandler OnPlayerStandOnFinalRoute;
    public Route currentRoute;

    public int routePosition;

    public int steps; 

    private bool isMoving;
    private void Start()
    {
        this.OnPlayerStandOnFinalRoute += Stone_OnPlayerStandOnFinalRoute;
    }

    private void Stone_OnPlayerStandOnFinalRoute(object sender, EventArgs e)
    {
        GameOverUI.Instance.Show();
        Debug.Log("Game Over!");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            Debug.Log("FigureMoving");
            if(!isMoving)
            {
                steps = DiceNumberText.diceNumber;
                if(routePosition + steps < currentRoute.childNodeList.Count)
                {
                    StartCoroutine(Move());
                }
            }
        }
        
    }

    private IEnumerator Move()
    {
        if(isMoving)
        {
            yield break;
        }
        isMoving = true;

        while(steps > 0)
        {
            Vector3 nextPos = currentRoute.childNodeList[routePosition + 1].position;
            int gameOverValue = 4;
            if (nextPos == currentRoute.childNodeList[gameOverValue].position)
            {
                OnPlayerStandOnFinalRoute?.Invoke(this, EventArgs.Empty);
            }

            while(MoveToNextNote(nextPos))
            {
                yield return null;
            }

            yield return new WaitForSeconds(0.1f);
            steps--;
            routePosition++;
        }

        isMoving = false;
    }

    private bool MoveToNextNote(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 4f * Time.deltaTime));
    }
}
