using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{

    float timer;
    public Text timerText;
    public GameObject Timeout;
    public GameObject Canvas;

    // Use this for initialization
    void Start()
    {
        timer = 300.0f;

    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        timerText.text = "" + timer.ToString("0") + "s";

        if (timer <= 0.0f)
        {
            timer = 0.0f;
            Time.timeScale = 0;
            Canvas.SetActive(false);
            Timeout.SetActive(true);
        }

    }

}