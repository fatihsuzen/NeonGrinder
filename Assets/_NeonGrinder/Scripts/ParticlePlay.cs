using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlay : MonoBehaviour
{
    public ParticleSystem bomb;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bomb")
        {
            Destroy(collision.gameObject);
            return;
        }
        bomb.Play();
    }
}

