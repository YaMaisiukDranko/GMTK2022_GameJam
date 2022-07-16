using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiceNumberText : MonoBehaviour
{
    TMP_Text text;
    public static int diceNumber;

    // Use this for initialization
    void Start () {
        text = GetComponent<TMP_Text> ();
    }
	
    // Update is called once per frame
    void Update () {
        text.text = diceNumber.ToString ();
        Debug.Log(diceNumber);
    }
}
