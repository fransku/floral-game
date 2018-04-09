using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Normal_Piece_Behavior : MonoBehaviour
{

    public bool touchingVase = false;
   public bool dragging = true;
    public bool insideVase = false;
    public bool isFallingInVase = false;
    public bool stopped = false;

    SpriteRenderer sprite;
    VaseBehaviour vaseBehaviour;
    float fallYValue;
    
    float distance;

    private void Start()
    {
        vaseBehaviour = GameObject.FindGameObjectWithTag("vase").GetComponent<VaseBehaviour>();
        sprite = GetComponent<SpriteRenderer>();
        fallYValue = Random.Range(vaseBehaviour.vaseBottomPos.position.y, vaseBehaviour.vaseTopPos.position.y);
    }

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

    private void Update()
    {
        if (isFallingInVase)
        {
            if (sprite.bounds.min.y <= fallYValue)
            {
                isFallingInVase = false;
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                rb.gravityScale = 0;
                rb.velocity = Vector3.zero;
                Debug.Log("stop");
                stopped = true;
                GameObject.FindGameObjectWithTag("vase").GetComponent<VaseBehaviour>().clinker();

                GetComponent<Collider2D>().enabled = false;
            }
        }
        //rotation
        if  (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            gameObject.transform.Rotate(Time.deltaTime, 0, 4);
            
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            gameObject.transform.Rotate(Time.deltaTime, 0, -4);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "insideVase")
        {
            Debug.Log("inside vase");
            insideVase = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (Input.GetMouseButton(0))
        {
            if (collision.gameObject.tag == "insideVase")
            {
                Debug.Log("exiting vase");
                insideVase = false;
            }
        }
    }
}

