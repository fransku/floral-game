﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Normal_Piece_Behavior : MonoBehaviour
{

    public bool touchingVase = false;

    //  Vector2 point;  
    // Use this for initialization
    bool dragging = false;
    float distance;

    void OnMouseDown()
    {
        if (touchingVase == false)
        {
            distance = Vector3.Distance(transform.position, Camera.main.transform.position);
            dragging = true;
        }
        
    }

    void OnMouseUp()
    {
        dragging = false;
        
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    /*
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;

        }
        */

    }
    




}

