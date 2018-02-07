using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public GameObject finalScore;
	public GameObject Player;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		

		if ( Input.GetKey(KeyCode.R) ) {
			SceneManager.LoadScene("main");
		//	Player.playerScore = 0;
		}
		//finalScore.gameObject.GetComponent<Text> ().text = ("Final Score: " + (int)Player.playerScore);
	
	}
}
