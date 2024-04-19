using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class HelixManager : MonoBehaviour
{
    public GameObject[] rings;

    public int noOfRings;
    public float ringDistance = 5f;
    private float yPos;


    private void Start()
    {
        if (noOfRings <= 50)
        {
            noOfRings = GameManager.CurrentLevelIndex + 5;    
        }
        else
        {
            noOfRings = 50;
        }
        

        for (int i = 0; i < noOfRings; i++)
        {
            if (i == 0)
            {
                // Создание первого кольца.
                SpawnRings(0);
            }
            else
            {
                // Создания центральных колец (без первого и последнего).
                SpawnRings(Random.Range(1, rings.Length - 1));

            }
        }
        // Создание последнего кольца
        SpawnRings(rings.Length - 1);
    }

    void SpawnRings(int index)
    {
        GameObject newRing = Instantiate(rings[index], new Vector3(transform.position.x, yPos, transform.position.z), Quaternion.identity);
        yPos -= ringDistance;
        newRing.transform.parent = transform;
    }
}
