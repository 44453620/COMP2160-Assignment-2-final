using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    private float driveSpeed;
    public float driveScriptSpeed;
    private float rotateSpeed = 100.0f;
    public float driveScriptRotate;
    private float acceleration = 100.0f;
    private float brake = 100.0f;
    private float maxSpeed = 15.0f;
    private float forward;
    private float turn;

    void Update()
    {
       forward = Input.GetAxis("Vertical");
      if (forward > 0) 
      {
        driveSpeed += acceleration * Time.deltaTime;
      }
      else if (forward < 0) 
      {
        driveSpeed -= acceleration * Time.deltaTime;
      }
      else 
      {
             driveSpeed -= brake * Time.deltaTime;
      }
      driveSpeed = Mathf.Clamp(driveSpeed, -maxSpeed, maxSpeed); 
      Vector3 velocity = Vector3.forward * driveSpeed;
      transform.Translate(velocity * Time.deltaTime);  
      driveScriptSpeed = driveSpeed;

      if(forward != 0)
      {
          turn = Input.GetAxis("Horizontal");
      }
      else
      {
          turn = 0;
      }
      transform.Rotate (0, turn*rotateSpeed*Time.deltaTime, 0);
      driveScriptRotate = rotateSpeed;
      Debug.Break();
    } 
}




