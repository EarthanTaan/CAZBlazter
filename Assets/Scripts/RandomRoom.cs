using System.Collections.Generic;
using UnityEngine;

public class RandomRoom : MonoBehaviour
{
    [SerializeField] GameObject[] FurnitureSpawnPoints;
    [SerializeField] GameObject[] PropsToSpawn;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnRoomLayout();
    }

    void SpawnRoomLayout()
    {
        //int numberOfItemsToSpawn = 4;
        List<GameObject> selectedElements = new List<GameObject>();
        List<int> indices = new List<int>();

        // Create a list of indices for the array
        for (int i = 0; i < FurnitureSpawnPoints.Length; i++)
        {
            indices.Add(i);
        }

        // Randomly select elements from the array
        for (int i = 0; i < FurnitureSpawnPoints.Length; i++)
        {
            int randomIndex = Random.Range(0, indices.Count);
            selectedElements.Add(PropsToSpawn[indices[randomIndex]]);

            // Set the selected element to active
            selectedElements[i].SetActive(true);
            //Spawn Props at Spawn Points
            selectedElements[i].transform.position = FurnitureSpawnPoints[i].transform.position;
            indices.RemoveAt(randomIndex);
        }
    }
}
