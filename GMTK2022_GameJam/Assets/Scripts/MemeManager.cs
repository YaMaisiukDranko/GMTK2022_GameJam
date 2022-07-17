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
    public Image sr;
    public static int currentStep;
    private Stone _stone;
    public int spriteInt;
    public static bool isMoving;
    public bool diceDropped;
    
    public GameObject MainCamera;
   // public GameObject SecondCamera;

   public Button YesButt;
    public Button NoButt;
    public TMP_Text YesButtTMP;
    public TMP_Text NoButtTMP;
    public TMP_Text QuestionTMP;
    public GameObject MemePanel;

    public AudioSource NoAu;
    public AudioSource YesAu;



    private void Start()
    {
       // MemePanel = GameObject.FindGameObjectWithTag("MemePanel");
        currentStep = Stone.routePosition;
        currentSprite = sr.sprite;
        currentStep = spriteInt;
        isMoving = Stone.isMoving;
        //memeScreen = GameObject.FindWithTag("MemeScreen");
        sr = memeScreen.GetComponent<Image>();
        
        NoButtTMP = NoButt.GetComponentInChildren<TMP_Text>();
        YesButtTMP = YesButt.GetComponentInChildren<TMP_Text>();
    }

    private void Update()
    {
        currentStep = Stone.routePosition;
        spriteInt = Stone.routePosition;
        isMoving = Stone.isMoving;
        SetMemeToScreen();
 
        //SpecialMemes();
    }

    void SetMemeToScreen()
    {
        sr.sprite = memeSprites[spriteInt];
    }

   

    
    //QUESTIONS
    void Questions()
    {
        
    }
    

   /* void SpecialMemes()
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
    */
}
