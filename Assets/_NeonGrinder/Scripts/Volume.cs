using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public static float VolumeValue;
    public GameObject dynamicSound;
    void Start()
    {
        VolumeValue = GetComponent<Slider>().value;
        VolumeValue = PlayerPrefs.GetFloat("Volume");
        GetComponent<Slider>().value = VolumeValue;
    }
    public void ChangeValue()
    {
        PlayerPrefs.SetFloat("Volume", VolumeValue);
        dynamicSound.GetComponent<AudioSource>().volume = VolumeValue;
        VolumeValue = GetComponent<Slider>().value;
    }
}
