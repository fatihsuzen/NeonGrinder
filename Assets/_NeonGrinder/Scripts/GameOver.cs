using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverUI; 
    private void OnCollisionEnter(Collision collision)
    {   
        if (collision.collider.tag == "Bomb")
        {
            Destroy(collision.gameObject);
            return;
        }

        Invoke("TimeDelay", 1);
        GameOverUI.SetActive(true);
    }
    void TimeDelay()
    {
        Time.timeScale = 0f;
    }
    public void SceneLoader(int SceneNo)
    {
        Time.timeScale = 1f;
        Score.scoreCounter = 0;
        Spawner.SpawnCubetime = 1f;
        ObjectsTransformDown.ForceDown = 270;
        SceneManager.LoadScene(SceneNo);
        transform.DOKill();
    }
    
}
