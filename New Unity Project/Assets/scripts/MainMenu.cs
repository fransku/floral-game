﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	//public int score = 0;

	//public Text scoreText;

	// Use this for initialization
	void Start () {
//		main = GetComponent <AudioSource>();
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene("game");
            GameManager.manager.level = 1;
         
        }
    }
    public void OnClickGAME ()
        {
            SceneManager.LoadScene("game");
       // GameManager.manager.level = 1;

    }
    public void OnClickINSTRUCTION()
    {
      
    }

    public void OnClickOPTIONS()
    {
        
    }
    //scoreText.text = "Score: " + score;


}
