using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class MemeManager : MonoBehaviour
{
    public Sprite[] memeSprites;
    public Sprite currentSprite;
    public GameObject memeScreen;
    public SpriteRenderer sr;
    public int currentStep;
    private Stone _stone;
    public int spriteInt;

    

    private void Start()
    {
        currentSprite = sr.sprite;
        currentStep = _stone.routePosition;
        memeScreen = GameObject.Find("MemeSCREEN");
        sr = memeScreen.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        currentStep = _stone.routePosition;
        SetMemeToScreen();
    }

    void SetMemeToScreen()
    {
        sr.sprite = memeSprites[1];
    }
}
