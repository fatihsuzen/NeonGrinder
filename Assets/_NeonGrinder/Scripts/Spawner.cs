using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> cube = new List<GameObject>();
    public static float SpawnCubetime = 1f;
    public float minPosY, maxPosY;

    private void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(SpawnCubetime);
        Instantiate(cube[Random.Range(0, cube.Count)], new Vector3(Random.Range(minPosY, maxPosY), 25f, 5f), Quaternion.Euler(Random.Range(0f,90f), Random.Range(0f, 90f), Random.Range(0f, 90f)));
        StartCoroutine(Spawn());
    }    
}
