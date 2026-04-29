using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBehavior : MonoBehaviour
{

    //RoomGen RoomGen;
    public GameObject[] walls; // 0 - Up 1 -Down 2 - Right 3- Left
    public GameObject[] doors;

    //public Dictionary<int, Vector2> directionVectors = new Dictionary<int, Vector2>(); // 0 - Up 1 -Down 2 - Right 3- Left

    void Start()
    {
        //RoomGen = GetComponentInParent<RoomGen>();

            //directionVectors.Add(0, new Vector2(0, 1)); // Up
            //directionVectors.Add(1, new Vector2(0, -1)); // Down
            //directionVectors.Add(2, new Vector2(1, 0)); // Right
            //directionVectors.Add(3, new Vector2(-1, 0)); // Left
    }
    public void DecideRoomWallState(bool[] status, Direction dir)
    {
        for (int i = 0; i < status.Length; i++)
        {
            //doors[i].SetActive(status[i]);
            //walls[i].SetActive(!status[i]);
        }

        switch (dir)
        {
            case Direction.Up:
                doors[0].SetActive(true);
                walls[0].SetActive(false);
                break;
            case Direction.Down:
                doors[1].SetActive(true);
                walls[1].SetActive(false);
                break;
            case Direction.Right:
                doors[2].SetActive(true);
                walls[2].SetActive(false);
                break;
            case Direction.Left:
                doors[3].SetActive(true);
                walls[3].SetActive(false);
                break;
        }

        //RoomGen.HouseMap[RoomGen.Size.x / 2][RoomGen.Size.y / 2].visited = true;

    }

    private void Update()
    {

        
    }
    public enum Direction
    {
        Up = 0,
        Down = 1,
        Right = 2,
        Left = 3
    }

    public Direction direction;
}
