using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public static GameManager manager;


    public float score;
    public int level;

    public string playerName;

    public int ending;
    public bool gameOver = false;

    public bool firstRun = true;
    public GameObject level1;
    public GameObject level2;

    void Awake()
    {
        Debug.Log("level" + level);
        if (manager == null)
        {
            //DontDestroyOnLoad(gameObject);
            score = GameData.gameScore;

            //test
           // level = GameData.level;

            ///
            manager = this;
        }
        else if (manager != this)
        {
            Destroy(gameObject);
        }
       
    }

    void Update()
    {
        //    GameObject[] flowers = GameObject.FindGameObjectsWithTag("Flower");
        if (GameObject.FindGameObjectsWithTag("Flower").Length > 24)
        {
            SceneManager.LoadScene("endScene");
        }

        if (level == 1)
        {
            level1.SetActive(true);
            level2.SetActive(false);

        }
        if (level == 2)
        {
            level1.SetActive(false);
            level2.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            level = 1;
          

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            level = 2;
            
        }

    }

    public void OnString_PlayerName(string value)
    {
        playerName = value.ToUpper();
    }

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

