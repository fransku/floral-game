using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {

    public int levelCount;
    public GameObject level1;
    public GameObject level2;
    public  levelManager instance = null;
    void Awake () {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        if (levelCount == 1)
        {
            level1.SetActive(true);
            level2.SetActive(false);

        }
        if (levelCount == 2)
        {
            level1.SetActive(false);
            level2.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            levelCount = 1;


        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            levelCount = 2;

        }
    }
}
