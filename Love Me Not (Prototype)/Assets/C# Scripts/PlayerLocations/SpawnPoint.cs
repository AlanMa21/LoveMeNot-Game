using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Makes a spawnpoint for where the Player will start within that scene. Unsure if it will go against the Save and Load system

public class SpawnPoint : MonoBehaviour
{
    private void Start()
    {
        GameObject spawnPoint = GameObject.Find("SpawnPoint");

        if (spawnPoint != null)
        {
            transform.position = spawnPoint.transform.position;
        }
        else
        {
            Debug.LogWarning("SpawnPoint not found in the scene. Please add a GameObject named 'SpawnPoint' at the desired spawn location.");
        }
    }
}
