using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualControllerSchmetterling : MonoBehaviour
{

    public GameObject vbton;
    public AudioSource sound;
    // public Animator cubeAni;

    // Use this for initialization
    void Start()
    {
        //Debug.Log("Hallo irgendwas");
        vbton = GameObject.Find("VirtualButton2");
        vbton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Debug.Log("Hallo irgendwas2");

        sound.GetComponent<AudioSource>();

        Debug.Log("komponente angemeldet2");
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed2");
        sound.Play();
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        sound.Stop();
        Debug.Log("Button released");
    }
}


