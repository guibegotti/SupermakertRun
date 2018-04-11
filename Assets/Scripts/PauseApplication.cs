using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseApplication : MonoBehaviour
{

    public bool paused;
    public Button pauseButton;

    // Use this for initialization
    void Start ()
    {

        paused = false;

    }
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKey(KeyCode.P))
        {
            
            pauseButton.onClick.Invoke();

        }  

    }

    public void Pause()
    {
        paused = !paused;

        if (paused)
        {
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            Time.timeScale = 1;
        }
    }
}
