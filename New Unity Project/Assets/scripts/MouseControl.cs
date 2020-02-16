using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MouseControl : MonoBehaviour
{
    public GameObject dragFlower;
    Rigidbody2D rb;
    SpriteRenderer sr;
    public GameObject flowers;
    bool flipped = false;
    private Vector3 screenPoint;
    private Vector3 offset;

    public button buttonUI;

    public trashButtonScript tb;

    void Start()
    {
        dragFlower = null;
       screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

       // Cursor.visible = false;
        //  offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        
    }

    void Update()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;

        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);

           

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "Flower")
                {
                    dragFlower = hit.collider.gameObject;

                    //below is making the flower gameobject appear in front of others
                    buttonUI.flowerLayerCounter += 1;
                    dragFlower.GetComponent<SpriteRenderer>().sortingOrder = buttonUI.flowerLayerCounter;
                }


                


            }
        }

        /*
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "Flower")
                {
                   flowers = GameObject.FindGameObjectWithTag("Flower");
                    if (flipped == false)
                    {
                        flowers.transform.localRotation = Quaternion.Euler(0, 180, 0);
                        flipped = true;
                    } else
                    {
                        flowers.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        flipped = false;
                    }
                    Debug.Log("Right Clik");

                }
            }
        }*/
   

            if (Input.GetMouseButton(0))
        {
            if (dragFlower != null)
            {
                if (rb == null)
                {
                    rb = dragFlower.GetComponent<Rigidbody2D>();
                }  
                Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                pos.z = 0;
                rb.MovePosition(pos);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (dragFlower != null)
            {

                Normal_Piece_Behavior nPB = dragFlower.GetComponent<Normal_Piece_Behavior>();
                nPB.dragging = false;
                if (nPB.insideVase)
                {
                    rb.gravityScale = 100f;
                    nPB.isFallingInVase = true;
                    //dragFlower.GetComponent<Collider2D>().enabled = false;
                 
                }

                if (!tb.hovering)
                {
                    rb = null;
                    dragFlower = null;
                }
            }
        }

    }
}
