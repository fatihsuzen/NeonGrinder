using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI InfinityScoreText, BomberScoreText;
    void Start()
    {
        InfinityScoreText.text = PlayerPrefs.GetInt("1Score").ToString();
        BomberScoreText.text = PlayerPrefs.GetInt("2Score").ToString();
    }
}
