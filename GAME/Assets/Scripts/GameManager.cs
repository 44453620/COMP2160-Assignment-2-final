using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class GameManager : MonoBehaviour
{
    static private GameManager instance;
    static public GameManager Instance 
    {
        get 
        {
            if (instance == null)
            {
                Debug.LogError("There is no GameManager instance in the scene.");
            }
            return instance;
        }
    }

    public GameObject UI;
    public GameObject Car;

    bool gameOver = false;

    public GameObject WinPoint;

    // Start is called before the first frame update
    void Start()
    {
       GameStart();
        AnalyticsEvent.GameStart();
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

        Analytics.CustomEvent("gameOver", new Dictionary<string, object>
        {
            { "Time", UI.GetComponent<Timer>().timer.text.ToString()},
            { "Position", Car.GetComponent<Health>().saveLocation},
            { "Death by", Car.GetComponent<Health>().getOther}
        });
        AnalyticsEvent.GameOver();
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
            AnalyticsEvent.GameOver();
        }
    }
}
