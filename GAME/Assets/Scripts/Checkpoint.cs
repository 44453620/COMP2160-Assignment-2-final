using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    Transform car;
    private int dispChkPoint;

    public GameObject UI;
    //CarCheckpoints objAplha;
    public bool checkpointReached = false;

    private string elipseTime = "";

    public string getTime
    {
        get
        {
            return elipseTime;
        }
    }

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
                elipseTime = UI.GetComponent<Timer>().timer.text;
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
