using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    Transform car;
    private int dispChkPoint;
    //CarCheckpoints objAplha;
    public bool checkpointReached = false;

    void Start()
    {
        car = GameObject.Find("Car").transform;
    }

    void OnTriggerEnter (Collider other)
    {
        if(transform == CarCheckpoints.checkpointA[CarCheckpoints.currentCheckpoint].transform)
        {
            if((CarCheckpoints.currentCheckpoint + 1) <= (CarCheckpoints.checkpointA.Length))
            {
                CarCheckpoints.currentCheckpoint += 1;
                checkpointReached = true;
                Debug.Log("Checkpoint number: " + CarCheckpoints.currentCheckpoint);
            }
            else
            {
                CarCheckpoints.currentCheckpoint = 0;
            }
            //Dimmer();
        }
        dispChkPoint = CarCheckpoints.currentCheckpoint;
    }
}
