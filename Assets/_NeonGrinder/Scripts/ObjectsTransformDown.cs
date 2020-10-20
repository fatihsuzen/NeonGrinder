using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class ObjectsTransformDown : MonoBehaviour
{
    public static int ForceDown=200;
    //public static float TransformTime=5f;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.down* ForceDown);
        GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-1, 2), Random.Range(-1, 2), Random.Range(-1, 2)) * Random.Range(10,50));
        //Invoke("TransformDown", TransformTime);
    }
    public void TransformDown()
    {
        //transform.DOMoveY();
    }
}
