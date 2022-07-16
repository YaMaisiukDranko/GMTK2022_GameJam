using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleUI : MonoBehaviour
{
    private Transform secreatSpeach;
    private void Start()
    {
        secreatSpeach = GetComponent<Transform>();
        secreatSpeach.Find("secretSpeach").gameObject.SetActive(false);

        transform.Find("startBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });

        transform.Find("quitBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            secreatSpeach.Find("secretSpeach").gameObject.SetActive(true);
        });
    }
}
