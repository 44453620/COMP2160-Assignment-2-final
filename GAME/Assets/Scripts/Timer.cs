using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;

    private float time = 0f;
    private float second;
    private float minute;
    private float milisecond;

    private bool racing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (racing)
        {
        RunTimer();
        timer.text = "Time: " + minute.ToString("00") + ":" + second.ToString("00") + ":" + milisecond.ToString("00");
        }
    }

    public void Racing()
    {
        racing = true;
    }

    public void RaceOver()
    {
        racing = false;
    }

    public void ResetTimer()
    {
        minute = 0;
        second = 0;
        milisecond = 0;
    }

    void RunTimer()
    {
        time += Time.deltaTime;

        minute = (int)(time/60f);
        second = (int)(time%60f);
        milisecond = (int)(time * 100f) % 100; 
    }
}
