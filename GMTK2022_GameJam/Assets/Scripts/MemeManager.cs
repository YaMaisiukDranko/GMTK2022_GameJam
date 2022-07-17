using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

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
    public bool diceDropped;
    
    public GameObject MainCamera;
    public GameObject SecondCamera;
    
    public Button YesButt;
    public Button NoButt;
    public TMP_Text YesButtTMP;
    public TMP_Text NoButtTMP;
    public TMP_Text QuestionTMP;
    


    IEnumerator Delay()
    {
        if (currentStep >= 1)
        {
            if (isMoving == true && DiceNumberText.diceNumber > 1)
            {
                yield return new WaitForSeconds(1f);
                SecondCamera.SetActive(false);
                MainCamera.SetActive(true);
            }
            else if(isMoving == false && DiceNumberText.diceNumber > 1)
            {
                yield return new WaitForSeconds(2f);
                SecondCamera.SetActive(true);
                MainCamera.SetActive(false);
            }
            else if(DiceNumberText.diceNumber == 1)
            {
                SecondCamera.SetActive(false);
                MainCamera.SetActive(true);
            }
        }
        else
        {
            
        }
    }

    private void Start()
    {
        currentStep = Stone.routePosition;
        currentSprite = sr.sprite;
        currentStep = spriteInt;
        isMoving = Stone.isMoving;
        memeScreen = GameObject.FindWithTag("MemeScreen");
        sr = memeScreen.GetComponent<SpriteRenderer>();

        NoButtTMP = NoButt.GetComponentInChildren<TMP_Text>();
        YesButtTMP = YesButt.GetComponentInChildren<TMP_Text>();
    }

    private void Update()
    {
        currentStep = Stone.routePosition;
        spriteInt = Stone.routePosition;
        isMoving = Stone.isMoving;
        SetMemeToScreen();
        CameraChanger();
        SpecialMemes();
    }

    void SetMemeToScreen()
    {
        sr.sprite = memeSprites[spriteInt];
    }

    public void CameraChanger()
    {
        StartCoroutine(Delay());
    }

    
    //QUESTIONS
    
    void Questions()
    {
        
       
    }

    public void OnClickYes(int kickProbability)
    {
        MainCamera.SetActive(true);
        SecondCamera.SetActive(false);
        
        kickProbability = Random.Range(1, 6);
        if (kickProbability == 2)
        {
            
            OnClickNo(kickProbability);
        }
        else
        {
            
        }
    }
    
    public void OnClickNo(int yesProbability)
    {
        MainCamera.SetActive(true);
        SecondCamera.SetActive(false);
        yesProbability = Random.Range(1, 8);
        if (yesProbability == 4)
        {
            
            OnClickYes(yesProbability);
        }
        else
        {
            
        }
    }

    void SpecialMemes()
    {
        if (currentStep == 4)
        {
            QuestionTMP.text = "Put extra phrase";
            YesButtTMP.fontSize = 15;
            YesButtTMP.text = "Ah, humor based on my pain";
            NoButtTMP.text = "No";
        }
        else
        {
            QuestionTMP.text = "Do yo like this meme";
            YesButtTMP.fontSize = 35;
            YesButtTMP.text = "Yes";
            NoButtTMP.text = "No";
        }
    }
    
    
   
}
