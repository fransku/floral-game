using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flower : MonoBehaviour {

    private Vector3 screenPoint;
  

    //GameManager gameManager1;
    // Use this for initialization
    void Start () {
        //  gameManager1 = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
   
         screenPoint = Camera.main.WorldToScreenPoint(this.gameObject.transform.position);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
           
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
            transform.position = curPosition;
        }
      
        if (Input.GetMouseButtonUp(0))
        {
            Drop();
        }

    }
    public void Drop()
    {
        GameObject vase1 = GameObject.Find("vase");
        float distance = Vector3.Distance(this.gameObject.transform.position, vase1.transform.position);
        if (distance < 30)
        {
            GameManager.manager.score += 1;
            this.gameObject.transform.position = vase1.transform.position;

        }

    }

}
 