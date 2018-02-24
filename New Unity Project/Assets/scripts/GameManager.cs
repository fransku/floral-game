using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    
    public static GameManager manager;


    public int score = 0;
    public int level = 1;

    public string playerName;
    
    public int ending;
    public bool gameOver = false;
    public bool firstRun = true;

    void Awake()
    {
      
        if (manager == null)
        {
            //DontDestroyOnLoad(gameObject);
            score = GameData.gameScore;
            manager = this;
        }
        else if (manager != this)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
       // CheckEnd();
    }
    
    public void OnString_PlayerName(string value)
    {
        playerName = value.ToUpper();
    }
    /*
    // function to check ending
    public void CheckEnd()
    {
        // check stats to see if game has ended
        if (score >= 10)
        {
            ending = 1;
            gameOver = true;
        }

        // if true switch scenes
        if (gameOver == true && firstRun == true)
        {
            SceneManager.LoadScene("endScene", LoadSceneMode.Single);
            firstRun = false;
        }
    }*/
}
