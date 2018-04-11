using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyController : MonoBehaviour {

    float money;
    string strippedString;
    public Text moneyText;
    public GameObject Moneyout;

    // Use this for initialization
    void Start ()
    {

        
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        strippedString = (moneyText.text).Replace(",", ".").Replace("R$", "");
        money = float.Parse(strippedString);

        if (money == 0)
        {
            Time.timeScale = 0;
            Moneyout.SetActive(true);
        }

    }

}
