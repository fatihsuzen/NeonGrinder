using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVolume : MonoBehaviour
{
    void Start()
    {
        GetComponent<AudioSource>().volume = Volume.VolumeValue;
    }
}
