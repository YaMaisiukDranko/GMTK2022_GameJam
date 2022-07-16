using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleUI : MonoBehaviour
{
    private void Start()
    {
        transform.Find("startBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            SceneManager.LoadScene(0);
        });
    }
}
