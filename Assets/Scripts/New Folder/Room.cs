using UnityEngine;

public class Room : MonoBehaviour
{
    public bool visited = false;
    public bool[] status = new bool[4]; // 0 - Up 1 -Down 2 - Right 3- Left
    public GameObject roomObject;
    public Vector2Int position;
    public Room(int x, int y, RoomGen gen)
    {
        position = new Vector2Int(x, y);
        roomObject = gen.gameObject;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
