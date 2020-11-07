﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{   
    public static int maxHealth = 100;

    public GameObject Smokes;
    public GameObject Explosion;

    private int health;
    
    private float lifeTime = 0f;

    public int getHealth
    {
        get
        {
            return health;
        }
    }

    public void setHealth(int hp)
    {
        health = hp;
    }

    public void reduceHealth(int setDamage)
    {
        health -= setDamage;
    }

    public void gainHealth(int setIncrement)
    {
        health += setIncrement;
    }

    // Start is called before the first frame update
    void Start()
    {
        Smokes.SetActive(false);
        Explosion.SetActive(false);
        setHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 50)
        {
            Smokes.SetActive(true);
        }

        if (health <= 0)
        {
            Smokes.SetActive(false);

            lifeTime += Time.deltaTime;
            Debug.Log(lifeTime);

            if (lifeTime > 0f && lifeTime <=2f)
            {
            Explosion.SetActive(true);
            this.GetComponent<Drive>().enabled = false;
            }

            if (lifeTime > 2f)
            {
            Explosion.SetActive(false);
            Destroy(this.gameObject);
            }
        }
    }

    void OnTriggerEnter(Collider obstruction)
    {
        if (obstruction.gameObject.tag == "Danger")
        {
            if (this.GetComponent<Drive>().getSpeed >= 20 || this.GetComponent<Drive>().getSpeed <= -20)
            {
                reduceHealth(Mathf.Abs(Mathf.RoundToInt(this.GetComponent<Drive>().getSpeed * 1.2f)));
            }
        }
        
        if (obstruction.gameObject.tag == "Checkpoint")
        {
            if (getHealth >= 75)
            {
                setHealth(maxHealth);
            }
            else
            {
                gainHealth(25);
            }
        }
    }
}
