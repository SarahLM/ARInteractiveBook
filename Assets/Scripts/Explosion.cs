using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject Sonne;
    public GameObject Meteor;
    public GameObject Explode;

    float minDistance = 0.0600000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    // Update is called once per frame
    void Update()
    {
        

        Vector3 radiussun = Sonne.transform.localScale/2;
        Vector3 radiusmeteor = Meteor.transform.localScale;
       
        float distance = Vector3.Distance(Meteor.transform.position, Sonne.transform.position);
        //float minDistance = Vector3.Distance(radiussun, Sonne.transform.position);
        


        //Debug.Log("Sun Position" + Sonne.transform.position + "radius: " + radiussun);
        Debug.Log("Meteor Position" + Meteor.transform.position + "radius: " + radiusmeteor + radiussun);

        Debug.Log("Distance:" + distance );
        Debug.Log("DistanceSun:" + minDistance);


        bool isColliding = distance < minDistance;
        Debug.Log("Do earth and meteor collide ?" +isColliding);

        if (isColliding)
        {
            ParticleSystem exp = Explode.GetComponent<ParticleSystem>();
            exp.Play();
        }
        else
        {
            ParticleSystem exp = Explode.GetComponent<ParticleSystem>();
            exp.Stop();
        }

    }
}
