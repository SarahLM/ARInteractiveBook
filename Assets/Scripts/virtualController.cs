using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualController : MonoBehaviour
{

    public GameObject vbBtnObj;
    public AudioSource sounds;
    //public Animator cubeAnim;
     //public Animator cubeAni;

    // Use this for initialization
    void Start()
    {
        //Debug.Log("Hallo irgendwas");
        vbBtnObj = GameObject.Find("VirtualButton0");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
      
        Debug.Log("Hallo irgendwas");

        sounds.GetComponent<AudioSource>();
       // cubeAnim.GetComponent<Animator>();

        Debug.Log("komponente angemeldet");
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
        sounds.Play();
        //cubeAnim.Play("planet_animation");

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //sounds.Play("none");
        sounds.Stop();
        //cubeAnim.Play("none");
        Debug.Log("Button released");
    }
}


