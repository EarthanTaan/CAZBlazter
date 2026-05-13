using UnityEngine;

public class EmptyRoom: MonoBehaviour
{
    //Determine which doors are active

    [HideInInspector] public float airValue = 10;

    [SerializeField] GameObject[] WallItems;
    [SerializeField] GameObject[] GroundItems;
}
