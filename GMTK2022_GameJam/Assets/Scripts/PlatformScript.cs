using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public Collider trigger;
    private MemeScript _memeScript;
    public GameObject memeManager;

    private void Start()
    {
        trigger = GetComponentInChildren<Collider>();
        memeManager = GameObject.FindWithTag("MemeManager");
        _memeScript = memeManager.GetComponent<MemeScript>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("touch " + name);
            _memeScript.MemeShow();
        }
    }
}
