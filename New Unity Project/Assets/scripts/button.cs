using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public static GameManager manager;

    public MouseControl mouseControl;
    public GameObject flowerAST;
    public GameObject flowerROSE;
    public GameObject flowerBIRD;
    public GameObject flowerCAR;
    public GameObject flowerSTAT;
    public GameObject flowerSF;
    public GameObject flowerDAF;
    //column 2
    public GameObject flowerOR;
    public GameObject flowerTU;
    public GameObject flowerSNA;
    public GameObject flowerHYD;
    public GameObject flowerPEO;
    private Vector3 screenPoint;
    public AudioClip pickupsfx;
    public AudioSource pickupsource;

    public int flowerLayerCounter;

     void Update()
    {
        
    }

    void InstantiateFlower(GameObject flowerPrefab)
    {
        screenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        screenPoint.z = 0;
       
        //Vector3 _screenPoint = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        pickupsource.PlayOneShot(pickupsfx);
        GameObject flower = GameObject.Instantiate(flowerPrefab, screenPoint, Quaternion.identity) as GameObject;
        mouseControl.dragFlower = flower;

        //   flowerPrefab.layer += 1;
      
        flowerLayerCounter += 1;
        flower.GetComponent<SpriteRenderer>().sortingOrder = flowerLayerCounter; 
    }
   
    public void OnClickFlower (GameObject flowerPrefab)
    {
        InstantiateFlower(flowerPrefab);
        GameManager.manager.score += flowerPrefab.GetComponent<Normal_Piece_Behavior>().flowerPoints[GameManager.manager.level - 1];
        Debug.Log("score" + GameManager.manager.score);
    }
   


 
}
   

