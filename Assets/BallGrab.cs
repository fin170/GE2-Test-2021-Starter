using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGrab : MonoBehaviour
{
    bool hasball;

    public GameObject dog;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball" && hasball==false)
        {
           // other.transform.position = other.transform.position;
            other.transform.parent = dog.transform;
            
            hasball = true;
           
        }
    }
}
