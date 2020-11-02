using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HowToPlayBtn : MonoBehaviour
{
    public void HowToPlayFnc()
    {
        SceneManager.LoadScene("HowToPlay"); 
    }
    public void HowToPlayCloseSceneFnc()
    {
        SceneManager.LoadScene("Menu");
    }
}
