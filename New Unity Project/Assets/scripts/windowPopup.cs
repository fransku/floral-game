using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; //what are events pls explain

public class windowPopup : MonoBehaviour
{
    public UnityEvent displayWindow;

    public void OnEnable()
    {
        LeanTween.scale(gameObject, new Vector3(1, 1, 1), 0.5f).setOnComplete(OnComplete);
    }

    public void OnComplete()
    {
        if (displayWindow != null)
            displayWindow.Invoke(); 
    }

    //when exit button is pressed   
    public void ExitButton()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f).setOnComplete(DestroyMe);
    }

    public void DestroyMe()
    {
        Destroy(gameObject); 
    }
}
