using System.Collections;

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using Vuforia;




public class PlanetenChange : MonoBehaviour
{


    public GameObject Anzeige1, Anzeige2, Anzeige3, Anzeige4, Anzeige5, Anzeige6, Anzeige7, Anzeige8, Anzeige9, Erde, Venus, Mars, Jupiter, SaturnRinge, Saturn, Neptun, Merkur, Uranus, Sonne;
    string anzeige;

        
    void Start()
    {
        // Initalisierung der Gameobjekte, Sichtbarkeiten nach erkennen des Targets festlegen
        Anzeige1 = GameObject.Find("Anzeige1");
        Anzeige2 = GameObject.Find("Anzeige2");
        Anzeige3 = GameObject.Find("Anzeige3");
        Anzeige4 = GameObject.Find("Anzeige4");
        Anzeige5 = GameObject.Find("Anzeige5");
        Anzeige6 = GameObject.Find("Anzeige6");
        Anzeige7 = GameObject.Find("Anzeige7");
        Anzeige8 = GameObject.Find("Anzeige8");
        Anzeige9 = GameObject.Find("Anzeige9");
        
        Erde = GameObject.Find("Erde");
        Venus = GameObject.Find("Venus");
        Mars = GameObject.Find("Mars");
        Jupiter = GameObject.Find("Jupiter");
        SaturnRinge = GameObject.Find("SaturnRinge");
        Saturn = GameObject.Find("Saturn");
        Neptun = GameObject.Find("Neptun");
        UnityEngine.Debug.Log("Neptun gefunden");
        Merkur = GameObject.Find("Merkur");
        Uranus = GameObject.Find("Uranus");
        Sonne = GameObject.Find("Sonne");



        Anzeige2.SetActive(false);
        Anzeige3.SetActive(false);
        Anzeige4.SetActive(false);
        Anzeige5.SetActive(false);
        Anzeige6.SetActive(false);
        Anzeige7.SetActive(false);
        Anzeige8.SetActive(false);
        Anzeige9.SetActive(false);
   
        Venus.SetActive(false);
        Mars.SetActive(false);
        Jupiter.SetActive(false);
        SaturnRinge.SetActive(false);
        Saturn.SetActive(false);
        Neptun.SetActive(false);
        Merkur.SetActive(false);
        Uranus.SetActive(false);
        Sonne.SetActive(false);



        
    }

    void Update()
    {
        // Erkennung der Objekte und Touchinput auf mobiler Version Android
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)

        {

            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))

            {
                // Wechsel der Sichtbarkeiten 

                anzeige = Hit.collider.tag;
               
                    switch(anzeige)

                    {
                        case "Anzeige1":

                            Anzeige1.SetActive(false);
                            Anzeige2.SetActive(true);
                            Venus.SetActive(true);
                            Erde.SetActive(false);
                            Neptun.SetActive(false);
                            Saturn.SetActive(false);
                        break;

                        case "Anzeige2":

                            Anzeige3.SetActive(true);
                            Anzeige2.SetActive(false);
                            Mars.SetActive(true);
                            Venus.SetActive(false);

                            break;

                        case "Anzeige3":

                            Anzeige4.SetActive(true);
                            Anzeige3.SetActive(false);
                            Jupiter.SetActive(true);
                            Mars.SetActive(false);

                            break;

                        case "Anzeige4":

                            Anzeige5.SetActive(true);
                            Anzeige4.SetActive(false);
                            Saturn.SetActive(true);
                            SaturnRinge.SetActive(true);
                            Jupiter.SetActive(false);

                            break;
                        case "Anzeige5":

                            Anzeige6.SetActive(true);
                            Anzeige5.SetActive(false);
                            Neptun.SetActive(true);
                            Saturn.SetActive(false);
                            SaturnRinge.SetActive(false);

                            break;
                        case "Anzeige6":

                            Anzeige7.SetActive(true);
                            Anzeige6.SetActive(false);
                            Merkur.SetActive(true);
                            Neptun.SetActive(false);

                            break;
                        case "Anzeige7":

                            Anzeige8.SetActive(true);
                            Anzeige7.SetActive(false);
                            Uranus.SetActive(true);
                            Merkur.SetActive(false);

                            break;
                        case "Anzeige8":

                            Anzeige9.SetActive(true);
                            Anzeige8.SetActive(false);
                            Sonne.SetActive(true);
                            Uranus.SetActive(false);
                            break;
                        case "Anzeige9":

                            Anzeige9.SetActive(false);
                            Anzeige1.SetActive(true);
                            Erde.SetActive(true);
                            Sonne.SetActive(false);

                            break;
                       
                        default:
                            break;

                    }





               

            }

        }



    }

   

}