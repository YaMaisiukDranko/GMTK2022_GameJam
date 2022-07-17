using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour
{
    private Transform[] childObjects;
    public List<Transform> childNodeList = new List<Transform>();

    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        FillNodes();

        for (int i = 0; i < childNodeList.Count; i++)
        {
            Vector3 currentPosition = childNodeList[i].position;
            if(i > 0)
            {
                Vector3 prevPos = childNodeList[i - 1].position;
                Gizmos.DrawLine(prevPos, currentPosition);
            }
        }
    }

    private void FillNodes()
    {
        childNodeList.Clear();
        childObjects = GetComponentsInChildren<Transform>();

        foreach(Transform child in childObjects)
        {
            if(child != transform && child.name != "platform_v2") //Check Childs
            {
                childNodeList.Add(child);
            }
        }
    }
}
