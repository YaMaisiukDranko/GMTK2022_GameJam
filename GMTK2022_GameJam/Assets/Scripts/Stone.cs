using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public Route currentRoute;

    private int routePosition;

    public int steps;

    private bool isMoving;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            steps = Random.Range(1, 7);

            if(routePosition + steps < currentRoute.childNodeList.Count)
            {
                StartCoroutine(Move());
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
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 2f * Time.deltaTime));
    }
}
