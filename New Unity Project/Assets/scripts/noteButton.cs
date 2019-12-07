using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteButton : MonoBehaviour {
    public AudioClip notePresssfx;
    public AudioSource notePresssource;

     public  void OnClick ()
    {
        GameObject window1 = GameObject.Find("window");
        Animator anim = window1.GetComponent<Animator>();
        anim.SetBool("isMoving",true);
        notePresssource.PlayOneShot(notePresssfx);
    }
       
}
