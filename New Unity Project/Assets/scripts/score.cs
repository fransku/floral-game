using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour {
    public Text scoreUI;
    // Use this for initialization
    void Start () {
		if(scoreUI == null)
        {
            GameObject.Find("GameScore");
        }
	}
  
    // Update is called once per frame
    void Update () {
        if (scoreUI == null)
        {
            GameObject.Find("GameScore");
        }
        else
        {
            scoreUI.text = ("Score: " + GameManager.manager.score.ToString());
        }
        
    }

    public void OnClick ()
    {
        SceneManager.LoadScene("endScene", LoadSceneMode.Single);
        GameManager.manager.firstRun = false;
    }
}
