using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MouseControl : MonoBehaviour
{
    public GameObject dragFlower;

    private Vector3 screenPoint;
    private Vector3 offset;
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
                }
            }
        }

        if (Input.GetMouseButton(0))
        {
            if (dragFlower != null)
            {
                Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                pos.z = 0;
                dragFlower.transform.position = pos;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (dragFlower != null)
            {
                Normal_Piece_Behavior nPB = dragFlower.GetComponent<Normal_Piece_Behavior>();
                if (nPB.touchingVase)
                {
                    dragFlower.GetComponent<Collider2D>().enabled = false;
                }

                dragFlower = null;
            }
        }

    }
}
