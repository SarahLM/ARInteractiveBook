using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class interactionController : MonoBehaviour
{
    // Array für verschiedene Audios
    public AudioClip[] audioClips;

    public AudioSource sounds;

    string objectNames;



    // Use this for initialization

    void Start()
    {
        // Erkennen der Audiosource
        sounds = GetComponent<AudioSource>();



    }



    // Update is called once per frame

    void Update()
    {
        // Erkennung ob Touch auf Endgerät stattfindet
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)

        {

            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))

            {
                // Selektion nach Objektname 
                objectNames = Hit.transform.name;

                switch (objectNames)

                {

                    case "Button1":

                        sounds.clip = audioClips[0];

                        sounds.Play();

                        break;

                    case "Button2":

                        sounds.clip = audioClips[0];

                        sounds.Stop();

                        break;

                    default:

                        break;



                }

            }

        }



    }

}