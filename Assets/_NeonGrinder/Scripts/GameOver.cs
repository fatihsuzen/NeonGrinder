using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverUI; 
    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0f;
        GameOverUI.SetActive(true);
    }
    public void SceneLoader(int SceneNo)
    {
        Time.timeScale = 1f;
        Score.scoreCounter = 0;
        Spawner.SpawnCubetime = 1f;
        ObjectsTransformDown.ForceDown = 200;
        SceneManager.LoadScene(SceneNo);
    }
}
