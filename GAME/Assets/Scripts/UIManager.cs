using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{   
    static private UIManager instance;
    static public UIManager Instance 
    {
        get 
        {
            if (instance == null) 
            {
                Debug.LogError("There is not UIManager in the scene.");
            }            
            return instance;
        }
    }

    public RectTransform Bar;
    public GameObject Car;
    public GameObject GameOverPanel;
    public GameObject RaceOverPanel;

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

    public Text checkA;
    public Text checkB;
    public Text checkC;
    public Text checkD;
    public Text checkE;

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

    public void WinPanelOn()
    {
        RaceOverPanel.SetActive(true);
        CheckPointUpdate();
    }

    public void WinPanelOff()
    {
        RaceOverPanel.SetActive(false);
        StartCheck();
    }

    public void StartCheck()
    {
        check1.text = check1.name + ": Incomplete";
        checkA.text = check1.name + ": Incomplete";

        check2.text = check2.name + ": Incomplete";
        checkB.text = check2.name + ": Incomplete";

        check3.text = check3.name + ": Incomplete";
        checkC.text = checkC.name + ": Incomplete";

        check4.text = check4.name + ": Incomplete";
        checkD.text = checkD.name + ": Incomplete";

        check5.text = check5.name + ": Incomplete";
        checkE.text = checkE.name + ": Incomplete";
    }

    public void CheckPointUpdate()
    {
        if (Point1.GetComponent<Checkpoint>().checkpointReached)
        {
            check1.text = check1.name + ": complete at " + Point1.GetComponent<Checkpoint>().getTime;
            checkA.text = checkA.name + ": complete at " + Point1.GetComponent<Checkpoint>().getTime;
        }
        if (Point2.GetComponent<Checkpoint>().checkpointReached)
        {
            check2.text = check2.name + ": complete at " + Point2.GetComponent<Checkpoint>().getTime;
            checkB.text = checkB.name + ": complete at " + Point2.GetComponent<Checkpoint>().getTime;
        }
        if (Point3.GetComponent<Checkpoint>().checkpointReached)
        {
            check3.text = check3.name + ": complete at " + Point3.GetComponent<Checkpoint>().getTime;
            checkC.text = checkC.name + ": complete at " + Point3.GetComponent<Checkpoint>().getTime;
        }
        if (Point4.GetComponent<Checkpoint>().checkpointReached)
        {
            check4.text = check4.name + ": complete at " + Point4.GetComponent<Checkpoint>().getTime;
            checkD.text = checkD.name + ": complete at " + Point4.GetComponent<Checkpoint>().getTime;
        }
        if (Point5.GetComponent<Checkpoint>().checkpointReached)
        {
            check5.text = check5.name + ": complete at " + Point5.GetComponent<Checkpoint>().getTime;
            checkE.text = checkE.name + ": complete at " + Point5.GetComponent<Checkpoint>().getTime;
        }
    }
}
