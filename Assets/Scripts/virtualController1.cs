using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualController1 : MonoBehaviour
{

    public GameObject vbBtnObje;
    public Animator cubeAni;

    // Use this for initialization
    void Start()
    {
        vbBtnObje = GameObject.Find("VirtualButton1");

        vbBtnObje.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObje.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
       
        cubeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("planet_animation");
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Button released");
    }
}

























