using UnityEngine;

public class RoomBehavior : MonoBehaviour
{
    public GameObject[] doors;
    public GameObject[] walls;

    public void UpdateRoom(bool[] status)
    {
        for (int i = 0; i < status.Length; i++)
        {
            doors[i].SetActive(status[i]);
            walls[i].SetActive(!status[i]);
        }
    }
}
