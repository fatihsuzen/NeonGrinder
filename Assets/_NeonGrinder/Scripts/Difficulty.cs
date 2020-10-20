using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public static void DifficultyFunc()
    {
        if (Score.scoreCounter % 10 == 1)
        {
            if (Spawner.SpawnCubetime > 0.30f)
            {
                Spawner.SpawnCubetime -= 0.05f;
            }
            if (ObjectsTransformDown.ForceDown < 500)
            {
                ObjectsTransformDown.ForceDown += 20;
            }
        }
    }
}