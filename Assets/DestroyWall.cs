using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroyWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
        Destroy(this.gameObject);
        
    }
}
