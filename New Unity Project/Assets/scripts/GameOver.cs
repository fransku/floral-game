using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOver : MonoBehaviour {
    
    public GameObject textNextorLose;

    public GameObject buttonOption1;
    public GameObject buttonOption2; 
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		

		if ( Input.GetKey(KeyCode.R) ) {
			SceneManager.LoadScene("main");
            GameManager.manager.score = GameData.gameScore;

            //GameManager.manager.score = 0;
		}

        //WIN
        if (GameManager.manager.score >= 12)
        {
            textNextorLose.gameObject.GetComponent<Text>().text = ("Good Job, the customer loved it!");
            GameManager.manager.gameOver = false;
            buttonOption1.gameObject.GetComponent<Text>().text = ("Next Day");
            buttonOption2.gameObject.GetComponent<Text>().text = ("Try Again");
        }
        //EH
        if (GameManager.manager.score >= 5 && GameManager.manager.score <= 9)
        {
            textNextorLose.gameObject.GetComponent<Text>().text = ("Eh. The customer didn't seem too happy, but paid you anyway.");
            GameManager.manager.gameOver = false;
            buttonOption1.gameObject.GetComponent<Text>().text = ("Next Day");
            buttonOption2.gameObject.GetComponent<Text>().text = ("Try Again");

        }
        //LOSE
        if (GameManager.manager.score <= 4)
        {
            GameManager.manager.gameOver = true;
            textNextorLose.gameObject.GetComponent<Text>().text = ("You got a call from your boss after a complaint from a customer. You're fired");
            buttonOption1.gameObject.GetComponent<Text>().text = ("Try Again");
            buttonOption2.gameObject.GetComponent<Text>().text = ("Quit");

        }

        //finalScore.gameObject.GetComponent<Text> ().text = ("Final Score: " + GameManager.manager.score);

    }

    public void onClickButton1()
    {
        //WIN
        if (GameManager.manager.score >= 12)
        {
            SceneManager.LoadScene("game"); //next day
            Debug.Log("Level 2");
            Debug.Log(GameManager.manager.level);
        }
        //EH
        if (GameManager.manager.score >= 5 && GameManager.manager.score <= 9)
        {
            SceneManager.LoadScene("game"); //next day
            GameManager.manager.level += 1;
            Debug.Log(GameManager.manager.level);
        }
        //LOSE
        if (GameManager.manager.score <= 4)
        {
            SceneManager.LoadScene("game");
        }
    }
    public void onClickButton2()
    {
        if (GameManager.manager.score >= 12)
        {
            SceneManager.LoadScene("game");
           
        }
        if (GameManager.manager.score >= 5 && GameManager.manager.score <= 9)
        {
            SceneManager.LoadScene("game"); 
        }
        //LOSe
        if (GameManager.manager.score <= 4)
        {
            //quit 
            SceneManager.LoadScene("main");
        }
    }
}
