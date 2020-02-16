using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    Text t;

    float avgDeltaTime;

    bool isShowing;

    // Start is called before the first frame update
    void Start()
    {
        isShowing = false;
        t = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        avgDeltaTime = Mathf.Lerp(avgDeltaTime, Time.deltaTime, .05f);

        if (Input.GetKeyDown(KeyCode.F8))
            isShowing = !isShowing;

        if (isShowing)
            t.text = (1 / avgDeltaTime).ToString();
        else
            t.text = "";
    }
}
