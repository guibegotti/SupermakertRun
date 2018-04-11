using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateController : MonoBehaviour {

    public GameObject EndGame;
    public GameObject Timeout;
    public GameObject Moneyout;
    public GameObject button1;
    public GameObject button2;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (EndGame.activeSelf == true || Timeout.activeSelf == true || Moneyout.activeSelf == true)
        {
            button1.SetActive(false);
            button2.SetActive(false);
        }
    }
}
