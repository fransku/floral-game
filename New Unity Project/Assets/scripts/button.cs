﻿using System.Collections;
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
    //colum 2
    public GameObject flowerOR;
    public GameObject flowerTU;
    public GameObject flowerSNA;
    public GameObject flowerHYD;
    public GameObject flowerPEO;
    private Vector3 screenPoint;
    public AudioClip pickupsfx;
    public AudioSource pickupsource;
 
    void InstantiateFlower(GameObject flowerPrefab)
    {
        screenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        screenPoint.z = 0;
       
        //Vector3 _screenPoint = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        pickupsource.PlayOneShot(pickupsfx);
        GameObject flower = GameObject.Instantiate(flowerPrefab, screenPoint, Quaternion.identity) as GameObject;
        mouseControl.dragFlower = flower;
      //  flowerPrefab.layer += 1;
 
    }
    //first column 
    public void OnclickAST()
    {
        InstantiateFlower(flowerAST);
         if (GameManager.manager.level == 2) {
        GameManager.manager.score += 1;
        }
    }
    public void OnclickBIRD()
    {
        InstantiateFlower(flowerBIRD);
        if (GameManager.manager.level == 2)
        {
            GameManager.manager.score += 1;
       
        }
    }
    public void OnclickCAR()
    {
        InstantiateFlower(flowerCAR);
        if (GameManager.manager.level == 2)
        {
            GameManager.manager.score += 1;
        }
    }
    public void OnclickSTAT()
    {
        InstantiateFlower(flowerSTAT);
        if (GameManager.manager.level == 2)
        {
            GameManager.manager.score += 1;
        }
    }
    public void OnclickSF()
    {
        InstantiateFlower(flowerSF);
         if (GameManager.manager.level == 2)
        {
            GameManager.manager.score += 0.5f;
        }
    }
    public void OnclickDAF()
    {
        InstantiateFlower(flowerDAF);
        if (GameManager.manager.level == 2)
        {
           // if (flowerDAF.length)
            //{
                GameManager.manager.score -= 1;
          //  }
        }
    }
    //ccolumn 2
    public void OnclickOR()
    {
        InstantiateFlower(flowerOR);
        if (GameManager.manager.level == 2)
        {
            GameManager.manager.score += 0.5f;
        }

    }
    public void OnclickTU() //TULIP
    {
        InstantiateFlower(flowerTU);
        if (GameManager.manager.level == 2)
        {
            GameManager.manager.score += 0.2f;
        }
    }
    public void OnclickSNA() //SNAP
    {
        InstantiateFlower(flowerSNA);
        if (GameManager.manager.level == 2)
        {
            GameManager.manager.score += 1;
        }
    }
    public void OnclickHYD()
    {
        InstantiateFlower(flowerHYD);
        if (GameManager.manager.level == 2)
        {
            GameManager.manager.score += 0.1f;
        }
    }
    public void OnclickPEO()
    {
        InstantiateFlower(flowerPEO);
        if (GameManager.manager.level == 2)
        {
            GameManager.manager.score += 0.8f;
        }

    }
    public void OnclickROSE ()
    {
        InstantiateFlower(flowerROSE);
        if (GameManager.manager.level == 1)
        {
            GameManager.manager.score += 1;
        }
        if (GameManager.manager.level == 2)
        {
            GameManager.manager.score += 0.2f;
        }
    }
   


 
}
   

