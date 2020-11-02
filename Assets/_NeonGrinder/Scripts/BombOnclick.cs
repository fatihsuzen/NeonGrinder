using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombOnclick : MonoBehaviour
{
    public GameObject GameOverUI;
    public ParticleSystem BombEfect;
    private void OnMouseDown()
    {
        BombEfect.Play();
        Invoke("TimeDelay", 0.5f);
        GameOverUI.SetActive(true);
    }
    void TimeDelay()
    {
        Time.timeScale = 0f;
    } 
}
