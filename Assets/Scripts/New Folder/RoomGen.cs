using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class RoomGen : MonoBehaviour
{
    [SerializeField] GameObject[] SpawnLocations;
    [SerializeField] GameObject[] RoomTypes;
    [SerializeField] int minRooms = 5;
    [SerializeField] int maxRooms = 10;

    public Vector2Int Size;
    public Dictionary<int, Dictionary<int, Room>> HouseMap = new Dictionary<int, Dictionary<int, Room>>();
    public List<Room> AllGeo = new List<Room>();
    /*public class RoomTile
    {
        public bool visited = false;
        public bool[] status = new bool[4]; // 0 - Up 1 -Down 2 - Right 3- Left
        public GameObject roomObject;
        public Vector2Int position;
        public RoomTile(int x, int y, RoomGen gen)
        {
            position = new Vector2Int(x, y);
            roomObject = gen.gameObject;
        }
    }*/

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateRooms();
        BuildTileMap();
    }


    public void BuildTileMap()
    {
        //Two nested for loops lets us build a grid of room slots at our desired size
        for (int x = 0; x < Size.x; x++) for (int y = 0; y < Size.y; y++)
            {
                //Spawn a blank room slot into the position 
                Room g = new Room(x,y,this);
                if (!HouseMap.ContainsKey(x)) HouseMap.Add(x, new Dictionary<int, Room>());
                //Add it to the dictionary and list of slots
                HouseMap[x].Add(y, g);
                AllGeo.Add(g);
                Debug.Log("Created Geo " + x + " " + y);
            }
    }

    void GenerateRooms()
    {
        int numberOfRooms = Random.Range(minRooms, maxRooms);
        List<GameObject> selectedElements = new List<GameObject>();
        List<int> indices = new List<int>();

        // Create a list of indices for the array
        for (int i = 0; i < SpawnLocations.Length; i++)
        {
            indices.Add(i);
        }

        // Randomly select elements from the array
        for (int i = 0; i < numberOfRooms; i++)
        {
            int randomIndex = Random.Range(0, indices.Count);
            selectedElements.Add(SpawnLocations[indices[randomIndex]]);

            // Set the selected element to active
            selectedElements[i].SetActive(true);
            indices.RemoveAt(randomIndex);
        }

        foreach (GameObject room in selectedElements)
        {

            Instantiate(RoomTypes[Random.Range(0, RoomTypes.Length)], room.transform.position, Quaternion.identity);
        }
    }
}
