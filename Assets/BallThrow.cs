using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public float fireRate = 15f;
    private float nextTimeToFire = 0f;
    public GameObject ball;
    public float speed = 20;
    public Transform Hand;
    //  public Seek seek;
    public GameObject dog;


    public void Start()
    {
        dog = GameObject.Find("dog");
    }
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1 / fireRate;
            Shoot();
        }
    }
    public void Shoot()
    {
        GameObject bal = Instantiate(ball, Hand.position, Hand.rotation) as GameObject;
        bal.GetComponent<Rigidbody>().AddForce(Hand.forward * speed, ForceMode.Impulse);
        dog.GetComponent<Seek>().enabled = true;
        dog.GetComponentInChildren<Seek>().targetGameObject = bal;
        
    }
}
