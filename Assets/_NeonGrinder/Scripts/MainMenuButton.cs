using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public static int SceneNo;
    public void PlayButtonFunc()
    {
        SceneManager.LoadScene(SceneNo+1);
    }
}
