using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemeManager : MonoBehaviour
{
    public Sprite[] memeSprites;
    public SpriteRenderer sr;
    public int currentStep;
    private Stone _stone;
    private int spriteInt;

    private void Awake()
    {
        currentStep = _stone.routePosition;
    }

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        currentStep = _stone.routePosition;
    }

    void SetMemeToScreen()
    {
        sr.sprite = memeSprites[spriteInt];
    }
}
