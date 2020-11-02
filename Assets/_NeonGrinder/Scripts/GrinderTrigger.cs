using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GrinderTrigger : MonoBehaviour
{
    public GameObject grinderLeft, grinderRight;

    private void OnTriggerEnter(Collider other)
    {
        grinderLeft.transform.DOMoveX(-18f, 0.2f);
        grinderRight.transform.DOMoveX(18f, 0.2f);
        Invoke("GrinderMoveBack", 0.2f);
        DifficultyMap1.DifficultyFunc();
    }
    void GrinderMoveBack()
    {
        grinderLeft.transform.DOMoveX(-35f, 0.2f);
        grinderRight.transform.DOMoveX(35f, 0.2f);
    }
}
