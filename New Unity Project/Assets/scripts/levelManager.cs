using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {

 
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject notif;
	// Update is called once per frame
	void Update () {

        if (GameManager.manager.level == 1)
        {
            level1.SetActive(true);
            level2.SetActive(false);

        }
        if (GameManager.manager.level == 2)
        {
            level1.SetActive(false);
            level2.SetActive(true);
        }
        if (GameManager.manager.level == 3)
        {
            level2.SetActive(false);
            level3.SetActive(true);
        }
        if (GameManager.manager.level == 4)
        {
            level3.SetActive(false);
            level4.SetActive(true);
            notif.SetActive(false);
        }
    }
}
