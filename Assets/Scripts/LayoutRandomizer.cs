using System.Collections.Generic;
using UnityEngine;

public class LayoutRandomizer : MonoBehaviour
{
    [SerializeField] GameObject[] LevelLayouts;
    [SerializeField] GameObject[] Rooms;

    float totalValue; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateLevelLayout();
        CalcAirValue();
    }

    void CreateLevelLayout()
    {
        //int numberOfItemsToSpawn = 4;
        List<GameObject> selectedElements = new List<GameObject>();
        List<int> indices = new List<int>();

        // Create a list of indices for the array
        for (int i = 0; i < LevelLayouts.Length; i++)
        {
            indices.Add(i);
        }

        // Randomly select elements from the array
        for (int i = 0; i < 1; i++)
        {
            int randomIndex = Random.Range(0, indices.Count);
            selectedElements.Add(LevelLayouts[indices[randomIndex]]);

            // Set the selected element to active
            selectedElements[i].SetActive(true);
            indices.RemoveAt(randomIndex);

            //Get the rooms in the layout and randomize them as well
            var RoomsInLayout = selectedElements[i].GetComponentsInChildren<EmptyRoom>();

            for (int j = 0; j < RoomsInLayout.Length; j++)
            {
                RoomsInLayout[j].gameObject.SetActive(true);

                //Get transform of the each room and spawn a random room from the Rooms array at that position.

                Instantiate(Rooms[Random.Range(0, Rooms.Length)], RoomsInLayout[j].transform.position, Quaternion.identity, transform);
                //RoomsInLayout[j].transform.position = Rooms[j].transform.position;

            }
        }
    }
    void CalcAirValue()
    {
        EmptyRoom[] rooms = FindObjectsByType<EmptyRoom>(FindObjectsSortMode.None);
        Debug.Log("Found " + rooms.Length + " instances with this script attached");
        foreach (EmptyRoom rm in rooms)
        {
            //Take the value variable from the Appliance script and add all of them together to get a total value for the kitchen. Then print that value to the console.
            totalValue += rm.airValue;
            //Debug.Log("Total value: " + totalValue);
        }

        Appliance[] myItems = FindObjectsByType<Appliance>(FindObjectsSortMode.None);
        Debug.Log("Found " + myItems.Length + " instances with this script attached");
        foreach (Appliance item in myItems)
        {
            //Debug.Log(item.gameObject.name);
            //Take the value variable from the Appliance script and add all of them together to get a total value for the kitchen. Then print that value to the console.
            totalValue += item.value;
            Debug.Log("Total value: " + totalValue);
        }
    }


}
