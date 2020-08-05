using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class interactionController : MonoBehaviour
{

    public AudioClip[] audioClips;

    public AudioSource sonds;

    string objectNames;



    // Use this for initialization

    void Start()
    {

        sonds = GetComponent<AudioSource>();



    }



    // Update is called once per frame

    void Update()
    {

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)

        {

            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))

            {

                objectNames = Hit.transform.name;

                switch (objectNames)

                {

                    case "Button1":

                        sonds.clip = audioClips[0];

                        sonds.Play();

                        break;

                    case "Button2":

                        sonds.clip = audioClips[1];

                        sonds.Play();

                        break;

                    case "space_man_mod":

                        sonds.clip = audioClips[2];

                        sonds.Play();

                        break;

                    default:

                        break;



                }

            }

        }



    }

}