using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour {

    public AudioMixer audiomixer;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene("game");
            GameManager.manager.level = 1;
         
        }
    }
    public void OnClickGAME ()
        {
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
