using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyMap2 : MonoBehaviour
{
    public static void DifficultyFunc()
    {
        if (Score.scoreCounter % 5 == 1)
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