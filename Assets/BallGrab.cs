using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGrab : MonoBehaviour
{
    bool hasball;

    public GameObject dog;
    public void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball" && hasball==false)
        {
           
            other.transform.parent = dog.transform;
            
            hasball = true;
            dog.GetComponent<Arrive>().enabled = true;
            dog.GetComponent<Seek>().enabled = false;

        }
    }
}
