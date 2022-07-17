using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public static GameOverUI Instance { get; private set; }
    private void Awake()
    {
        Instance = this;

        transform.Find("restartBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });

        transform.Find("menuBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            SceneManager.LoadScene(0);
        });
    }
    private void Start()
    {
        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
