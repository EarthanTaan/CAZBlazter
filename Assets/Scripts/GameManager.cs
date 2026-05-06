using UnityEngine;

public class GameManager : MonoBehaviour
{

    float totalValue = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
