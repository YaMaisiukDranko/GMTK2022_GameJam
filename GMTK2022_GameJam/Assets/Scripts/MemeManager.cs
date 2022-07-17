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
    public bool isMoving;
    public GameObject MainCamera;
    public GameObject SecondCamera;


    IEnumerator Delay()
    {
        if (isMoving == true)
        {
            yield return new WaitForSeconds(0.5f);
            SecondCamera.SetActive(false);
            MainCamera.SetActive(true);
        }
        else if(isMoving == false)
        {
            yield return new WaitForSeconds(0.5f);
            SecondCamera.SetActive(true);
            MainCamera.SetActive(false);
        }
        
    }

    private void Start()
    {
        currentSprite = sr.sprite;
        currentStep = spriteInt;
        isMoving = Stone.isMoving;
        memeScreen = GameObject.FindWithTag("MemeScreen");
        sr = memeScreen.GetComponent<SpriteRenderer>();
        
    }

    private void Update()
    {
        currentStep = Stone.routePosition;
        spriteInt = Stone.routePosition;
        isMoving = Stone.isMoving;
        SetMemeToScreen();
        CameraChanger();
    }

    void SetMemeToScreen()
    {
        sr.sprite = memeSprites[spriteInt];
    }

    public void CameraChanger()
    {
        StartCoroutine(Delay());
    }

   
}
