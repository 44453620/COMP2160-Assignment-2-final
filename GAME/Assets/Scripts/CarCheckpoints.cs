using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCheckpoints : MonoBehaviour
{
    public Transform[] checkpointArray;
    public static Transform[] checkpointA;
    public static int currentCheckpoint;

    void Start()
    {
        currentCheckpoint = 0;
    }

    void Update()
    {
        checkpointA = checkpointArray;
    }
}
