using UnityEngine;

public class Appliance : MonoBehaviour
{

    public enum ApplianceType
    {
        Stove,
        Fridge,
        Sink,
        Counter
    }
    public ApplianceType type;

    public bool isClean = true;
    public float value = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
