using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class doneButtonScript : MonoBehaviour
{
    public AudioClip buttonPresssfx;
    public AudioSource notePresssource;

    public LeanTweenType easeType;

    public void OnClick()
    {
        /*Animator anim = this.GetComponent<Animator>();
      anim.SetBool("clicked", true);*/
        LeanTween.moveX(gameObject.GetComponent<RectTransform>(), 500f, 1f).setEase(easeType);

        notePresssource.PlayOneShot(buttonPresssfx);

        StartCoroutine(DoneClickedCoroutine());


    }

    IEnumerator DoneClickedCoroutine()
    {
      
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("endScene", LoadSceneMode.Single);
        GameManager.manager.firstRun = false;

    }

}
