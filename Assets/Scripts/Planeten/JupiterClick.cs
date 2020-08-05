using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JupiterClick: MonoBehaviour
    {



    public GameObject Text;

    public void Start()
    {
        Text = GameObject.Find("Jupiter_text");
        Text.SetActive(false);

    }

    public void OnMouseDown()
    {
        Text.SetActive(true);
    }

    public void OnMouseUp()
    {
        Text.SetActive(false);
    }
    /*public bool isClicked = false;
    public string name = "Some name";

    public void Start()
    {
        if (gameObject.GetComponent(Collider) == null)
            gameObject.AddComponent(typeof(BoxCollider));
    }

    public void OnMouseDown()
    {
        isClicked = true;
    }

    public void OnMouseUp()
    {
        isClicked = false;
    }

    public void OnGUI()
    {
        if (isClicked)
            GUI.Label(new Rect(5, 5, 400, 100), "This is " + this.name);
    }
    /* public bool isClicked = false;

     void OnMouseDown()
         {
             print("Jupiter");
         //Destroy(this.gameObject);
         //GUI.Label(new Rect(5, 5, 400, 100), "This is Saturn" + this.name);
         isClicked = true;

     }
     public void OnGUI()
     {
         if (isClicked)
             GUI.Label(new Rect(5, 5, 400, 100), "This is Saturn");
     }*/
}
