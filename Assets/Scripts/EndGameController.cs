using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController : MonoBehaviour {

    public GameObject EndGame;
    public GameObject listone;
    public GameObject listtwo;
    public GameObject listthree;
    public GameObject listfour;
    public GameObject listfive;
    public GameObject listsix;
    public GameObject listseven;
    public GameObject listeight;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (listone.activeSelf == false && listtwo.activeSelf == false && listthree.activeSelf == false &&
            listfour.activeSelf == false && listfive.activeSelf == false && listsix.activeSelf == false &&
            listseven.activeSelf == false && listeight.activeSelf == false)
        {
            Time.timeScale = 0;
            EndGame.SetActive(true);
        }

    }
}
