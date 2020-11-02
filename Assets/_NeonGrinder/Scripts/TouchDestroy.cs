using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TouchDestroy : MonoBehaviour
{
    public ParticleSystem particle;

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * ObjectsTransformDown.ForceDown);
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<AudioSource>().Play();
        gameObject.transform.DOScale(new Vector3(0, 0, 0), 1f);
        Invoke("ObjectDestroy",1);
        Score.scoreCounter += 1;
        particle.Play();
        DifficultyMap2.DifficultyFunc();
    }
    public void ObjectDestroy()
    {
        Destroy(gameObject);
    }
}
