﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject UI;

    bool gameOver = false;

    public GameObject WinPoint;

    // Start is called before the first frame update
    void Start()
    {
       GameStart();
    }

    // Update is called once per frame
    void Update()
    {
       var Player = GameObject.Find("Car");
      
       if (Player == null)
       {
           gameOver = true;
       }
       
       if (gameOver)
       {
           GameOver();
       }

       WinRace();
    }

    void GameOver()
    {
        UI.GetComponent<UIManager>().OverPanelOn();
        UI.GetComponent<Timer>().RaceOver();
    }

    public void GameStart()
    {
        UI.GetComponent<Timer>().ResetTimer();
        UI.GetComponent<UIManager>().OverPanelOff();
        UI.GetComponent<UIManager>().WinPanelOff();
        UI.GetComponent<Timer>().Racing();
    }

    void WinRace()
    {
        if (WinPoint.GetComponent<Checkpoint>().checkpointReached)
        {
            UI.GetComponent<UIManager>().WinPanelOn();
            UI.GetComponent<Timer>().RaceOver();
        }
    }
}
