using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGrab : MonoBehaviour
{
    bool hasball;
   public bool unattach;

    public GameObject dog;
    public Collider ballCo;
    public void Start()
    {
        
    }
    private void OnTriggerEnter(Collider ballCo)
    {
        if (ballCo.gameObject.tag == "Ball" && hasball==false)
        {
           
            ballCo.transform.parent = dog.transform;
            
            hasball = true;
            dog.GetComponent<Arrive>().enabled = true;
            dog.GetComponent<Seek>().enabled = false;

        }
    }

    public void Update()
    {
        if (unattach)
        {
            ballCo.transform.parent = null;
            unattach = false;
            hasball = false;
        }
    }
}
