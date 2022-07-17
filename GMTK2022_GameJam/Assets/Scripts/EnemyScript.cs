using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Route currentRoute;

    public int routePosition;

    public int steps;

    private bool EnemyisMoving;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !EnemyisMoving)
        {
            Debug.Log("EnemyMoving");
            if(!EnemyisMoving)
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
        if(EnemyisMoving)
        {
            yield break;
        }
        EnemyisMoving = true;

        while(steps > 0)
        {
            Vector3 nextPos = currentRoute.childNodeList[routePosition + 1].position;

            while(MoveToNextNode(nextPos))
            {
                yield return null;
            }

            yield return new WaitForSeconds(0.1f);
            steps--;
            routePosition++;
        }

        EnemyisMoving = false;
    }

    private bool MoveToNextNode(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 4f * Time.deltaTime));
    }
}
