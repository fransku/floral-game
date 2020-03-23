using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelManager : MonoBehaviour {

    //notes: levels will only work if you disable all levels in the inspector before playing.
    //   public GameObject[] level = new GameObject[1,2,3,4,5,6,7]; there must be a easier way to do this...

    public GameObject level1;
    public GameObject mainLevels;
    public GameObject lastLevel;
    
    public Text promptText;
    public Text windowText;

     void Start()
    {
        //this makes it easier to see everything once we have more levels; but we can't use it because its only for active gameobjects.
        //i'll put it off for now 12/05
       // Text windowText = GameObject.Find("windowText").GetComponent<Text>();
        //Text promptText = GameObject.Find("message").GetComponent<Text>();

    }

    void Update () {

        if (GameManager.manager.level == 1)
        {
            //tutorial level
            level1.SetActive(true);
            mainLevels.SetActive(false);
            //promptText.text = "testotesto"; 

        }
        if (GameManager.manager.level == 2)
        {
            
            level1.SetActive(false);
            mainLevels.SetActive(true);

            promptText.text = "Dear Florist, my daughter has her graduation ceremony tomorrow! Shes worked so hard and I want her to know that there is such a bright future ahead of her!";
        }
        if (GameManager.manager.level == 3)
        {
          promptText.text = "My father is starting his new company as a passion project. Hes losing a lot of money and people say he will fail but I believe in him and want to give him encouragement. ";
        }
        if (GameManager.manager.level == 4)
        {
            
        }

        if (GameManager.manager.level == 5)
        {
           
        }
    }
}
