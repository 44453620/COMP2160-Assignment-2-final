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
    private float maxSpeed = 25.0f;
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
        if(!(Input.GetKeyDown("Vertical")))
        {
             driveSpeed -= brake * Time.deltaTime;
        }
      }
      driveSpeed = Mathf.Clamp(driveSpeed, -maxSpeed, maxSpeed); 
      Vector3 velocity = Vector3.forward * driveSpeed;
      transform.Translate(velocity * Time.deltaTime);  
      driveScriptSpeed = driveSpeed;

      if(forward != 0)
      {
          turn = Input.GetAxis("Horizontal");
          if(forward < 0)
          {
            turn *= -1;
          }
      }
      else
      {
          turn = 0;
      }
      transform.Rotate (0, turn*rotateSpeed*Time.deltaTime, 0);
      driveScriptRotate = rotateSpeed;
    } 
}




