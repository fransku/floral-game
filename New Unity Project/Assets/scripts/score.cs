﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour {
    public GameObject scoreUI;
    public GameObject scoreUI2;

//ATTENTION this code is currently useless, maybe add score in the future?

    void Start () {
		
	}
  
    // Update is called once per frame
    void Update () {
       
       // scoreUI.gameObject.GetComponent<Text>().text = ("Score: " + GameManager.manager.score);
       // scoreUI2.gameObject.GetComponent<Text>().text = ("Score: " + GameManager.manager.score);

    }

    public void OnClick ()
    {
      
    }
}
