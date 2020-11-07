using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{   
    public static UIManager instance;

    public RectTransform Bar;
    public GameObject Car;
    public GameObject GameOverPanel;

    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public GameObject Point4;
    public GameObject Point5;

    public Text check1;
    public Text check2;
    public Text check3;
    public Text check4;
    public Text check5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       float hp = Car.GetComponent<Health>().getHealth;
       Bar.sizeDelta = new Vector2 ((hp*7), 13);
    }

    public void OverPanelOn()
    {
        GameOverPanel.SetActive(true);
        CheckPointUpdate();
    }

    public void OverPanelOff()
    {
        GameOverPanel.SetActive(false);
        StartCheck();
    }

    public void StartCheck()
    {
        check1.text = check1.name + ": Incomplete";
        check2.text = check2.name + ": Incomplete";
        check3.text = check3.name + ": Incomplete";
        check4.text = check4.name + ": Incomplete";
        check5.text = check5.name + ": Incomplete";
    }

    public void CheckPointUpdate()
    {
        if (Point1.GetComponent<Checkpoint>().checkpointReached)
        {
            check1.text = check1.name + ": complete at " + Point1.GetComponent<Checkpoint>().getTime;
        }
        if (Point2.GetComponent<Checkpoint>().checkpointReached)
        {
            check2.text = check2.name + ": complete at " + Point2.GetComponent<Checkpoint>().getTime;
        }
        if (Point3.GetComponent<Checkpoint>().checkpointReached)
        {
            check3.text = check3.name + ": complete at " + Point3.GetComponent<Checkpoint>().getTime;
        }
        if (Point4.GetComponent<Checkpoint>().checkpointReached)
        {
            check4.text = check4.name + ": complete at " + Point4.GetComponent<Checkpoint>().getTime;
        }
        if (Point5.GetComponent<Checkpoint>().checkpointReached)
        {
            check5.text = check5.name + ": complete at " + Point5.GetComponent<Checkpoint>().getTime;
        }
    }
}
