using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WallDetection : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Room"))
        {
            //this.gameObject.SetActive(false);
            Debug.Log("Collided with " + other.gameObject.name);
            GameObject parentObject = transform.parent.gameObject;
            parentObject.SetActive(false);
            
        }
    }
}
