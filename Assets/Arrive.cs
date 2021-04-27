using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Arrive : SteeringBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;
    public Transform player;
    public Transform dog;
    public GameObject targetGameObject = null;
    Seek gameobj;
    public BallGrab parent;
    public override Vector3 Calculate()
    {
        return boid.ArriveForce(targetPosition, slowingDistance);
    }

    public void Update()
    {
        if (targetGameObject != null)
        {
            targetPosition = new Vector3(targetGameObject.transform.position.x, 0f, targetGameObject.transform.position.z);
        }
        if (Vector3.Distance(player.position, dog.position) < 10)
        {

            GetComponent<Arrive>().enabled = false;
            boid.velocity = Vector3.zero;

            //targetGameObject.transform.parent;
               parent.unattach = true;
            parent.transform.SetParent(null);
        }
    }

}