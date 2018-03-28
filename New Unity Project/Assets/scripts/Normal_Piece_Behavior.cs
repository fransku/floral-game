using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Normal_Piece_Behavior : MonoBehaviour
{

    public bool touchingVase = false;
   public bool dragging = true;
    float distance;

    void OnMouseDown()
    {
            distance = Vector3.Distance(transform.position, Camera.main.transform.position);
            dragging = true;
        Debug.Log("dragging");
        
    }

    void OnMouseUp()
    {
        dragging = false;
        Debug.Log("released");
    }
 
}

