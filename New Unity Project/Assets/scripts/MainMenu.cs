using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour {

    public AudioMixer audiomixer;
    // public Animator fadeAnim;
    //  bool fadeInAnimStart;

    public LeanTweenType easeType;

    public GameObject titleText;
    Animator titleAnim;
    
    void Start()
    {
     //   fadeAnim = GetComponent<Animator>();
        titleAnim = titleText.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("game");
            GameManager.manager.level = 1;
        }

        /* not sure why i get object reference not set to instance.. 
        if (GameManager.manager.firstRun == true)
        {
               // StartCoroutine(StartCutscene());
         }*/

        StartCoroutine(StartCutscene());
    }

    IEnumerator StartCutscene()
    {
        yield return new WaitForSeconds(3);
        //  fadeAnim.SetBool("whiteFadeIn" = true);
        titleAnim.SetBool("startLogoAnim", true);
        Debug.Log("animation should be playing");
        yield return new WaitForSeconds(2);
    }


    public void OnClickGAME ()
        {

        LeanTween.scale(gameObject, new Vector2(0, 0), 0.5f).setEase(easeType);
            SceneManager.LoadScene("game");
       // GameManager.manager.level = 1;

    }


    public void OnClickINSTRUCTION()
    {
      
    }
    

    public void setVolume(float volume)
    {
        audiomixer.SetFloat("mainVolume", volume);
    }


    public void OnClickQUIT()
    {
        Application.Quit();
    }
    //scoreText.text = "Score: " + score;


}
