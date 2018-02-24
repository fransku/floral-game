using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerTextControl : MonoBehaviour {

    public Transform popupText;
    public static string textstatus = "off";

    public void OnMouseEnter()
    {
        if (textstatus == "off")
        {
            popupText.GetComponent<TextMesh>().text = "Rose: Red stands for love and admiration...";
            textstatus = "on";
            Instantiate(popupText, new Vector3(transform.position.x, transform.position.y + 2, 0), popupText.rotation);
        }
    }
    public void OnMouseExit()
    {
        if (textstatus == "on")
        {
            textstatus = "off";
        }
    }
}
