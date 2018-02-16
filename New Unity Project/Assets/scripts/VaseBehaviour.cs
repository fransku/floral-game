using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseBehaviour : MonoBehaviour {

    private const string FLOWER_PREFIX = "Flower";

    /*// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/

    private void OnTriggerEnter2D(Collider2D _flowerCollider)
    {
        if (_flowerCollider.tag == FLOWER_PREFIX)
        {
            //_flowerCollider.gameObject.transform.SetParent(this.gameObject.transform);
            _flowerCollider.GetComponent<Normal_Piece_Behavior>().touchingVase = true;
            //_flowerCollider.enabled = false;
        }
    }


    private void OnTriggerExit2D(Collider2D _flowerCollider)
    {
        if (_flowerCollider.tag == FLOWER_PREFIX)
        {
            _flowerCollider.GetComponent<Normal_Piece_Behavior>().touchingVase = false;
        }
    }
}
