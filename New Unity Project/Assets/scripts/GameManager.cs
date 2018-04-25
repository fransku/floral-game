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


    void Awake()
    {
    
        Debug.Log("level" + level);
        if (manager == null)
        {
           
            score = GameData.gameScore;

            manager = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        //    GameObject[] flowers = GameObject.FindGameObjectsWithTag("Flower");
 


        if (GameObject.FindGameObjectsWithTag("Flower").Length > 24)
        {
            SceneManager.LoadScene("endScene");
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
   

