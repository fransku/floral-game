using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public MouseControl mouseControl;
    public GameObject flower1;
    public GameObject flower2;

    private Vector3 screenPoint;

    void InstantiateFlower(GameObject flowerPrefab)
    {
        screenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        screenPoint.z = 0;
        //Vector3 _screenPoint = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        GameObject flower = GameObject.Instantiate(flowerPrefab, screenPoint, Quaternion.identity) as GameObject;
        mouseControl.dragFlower = flower;
    }

    public void OnclickAST()
    {
        InstantiateFlower(flower2);

    }
    public void OnclickROSE ()
    {
        InstantiateFlower(flower2);
    }
    public void OnMouseDrag()
    {
        flower2.transform.position = Input.mousePosition;

    }


 
}
   

