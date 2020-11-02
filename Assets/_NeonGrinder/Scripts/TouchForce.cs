using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TouchForce : MonoBehaviour
{   public ParticleSystem particleSystem;
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * ObjectsTransformDown.ForceDown);
        GetComponent<Rigidbody>().AddForce(Vector3.forward* 1000);
        GetComponent<AudioSource>().Play();
        particleSystem.Play();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="LeftGrinder"|| collision.collider.tag == "RightGrinder")
        {            
            Invoke("ObjectDestroy", 1);
            GetComponent<ParticleSystem>().Play();
        }        
    }
    public void ObjectDestroy()
    {
        Score.scoreCounter+=0.5f;
        Destroy(gameObject);
    }
}
