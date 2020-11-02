using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public static float scoreCounter;
    private InterstitialAd reklamObjesi;

    void Start()
    {
        InvokeRepeating("ScoreUpdate", 1f, 0.2f);
    }
    public void ScoreUpdate()
    {
        score.text = (int)scoreCounter + "";
        if ((int)scoreCounter > PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("Score", (int)scoreCounter);
        }
    }
}