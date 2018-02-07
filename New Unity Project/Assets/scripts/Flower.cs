using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour {



    GameManager gameManager1;
	// Use this for initialization
	void Start () {
        gameManager1 = GameObject.FindGameObjectsWithTag("GameController").GetComponent<GameManager>() ;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddValueToScore(1);
        }
		
	}

    void AddValueToScore (int value)
    {
        gameManager1.score += value;
        
    }
}
