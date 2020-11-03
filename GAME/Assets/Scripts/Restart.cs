using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void GameRestart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameManager.GetComponent<GameManager>().GameStart();
    }
}
