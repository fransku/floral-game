using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // create static instance so it can be accessed
    public static GameManager manager;


    public float score = 0;


    // set up player name variable
    public string playerName;

    // set up a variable to track ending
    public int ending;
    public bool gameOver = false;
    // bool to see if ending has run before
    public bool firstRun = true;

    void Awake()
    {
        // check if there's a manager created, if not, use this don't destroy it on load.
        if (manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }
        else if (manager != this)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        CheckEnd();
    }

    // function to set player name
    public void OnString_PlayerName(string value)
    {
        // set player name to the value of the uppercased value of the input
        playerName = value.ToUpper();
    }

    // function to check ending
    public void CheckEnd()
    {
        // check stats to see if game has ended
        if (score <= 10)
        {
            ending = 1;
            gameOver = true;
        }

        // if true switch scenes
        if (gameOver == true && firstRun == true)
        {
            SceneManager.LoadScene("endscene", LoadSceneMode.Single);
            firstRun = false;
        }
    }
}
