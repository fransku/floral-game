using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class trashButtonScript : MonoBehaviour
{
    public MouseControl mc;
    public bool hovering = false;
   // public button pb;
    public Sprite trashDown;
    public Sprite trashNormal;
    public Image trashImg;

    void Start()
    {
        trashImg = GetComponent<Image>();
    }

    void Update()
    {
        if(hovering && Input.GetMouseButtonUp(0))
        {
            throwAway();
            //pb.image.overrideSprite = trashSprite;
            StartCoroutine(trashUpDown()); 
        }
    }

    IEnumerator trashUpDown()
    {
        trashImg.sprite = trashDown;
        yield return new WaitForSeconds(0.5f);
        trashImg.sprite = trashNormal;

        //subtract points? how can I do this ASK CODE HELP
     //   GameManager.manager.score -= flowerPrefab.GetComponent<Normal_Piece_Behavior>().flowerPoints[GameManager.manager.level - 1];
    }

    //if mouse is hovering over trash
    public void hoverOver() {
        hovering = true;
    }
    public void hoverOff() {

        hovering = false;
    }

    //called in update
    public void throwAway()
    {
        if(mc.dragFlower != null)
        {
           GameManager.manager.score -= mc.dragFlower.GetComponent<Normal_Piece_Behavior>().flowerPoints[GameManager.manager.level -1];

            Destroy(mc.dragFlower.gameObject);
        }
    }
}
