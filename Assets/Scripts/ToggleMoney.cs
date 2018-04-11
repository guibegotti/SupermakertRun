using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleMoney : MonoBehaviour {

    float money;
    public float value;
    float sub;
    string strippedString;
    public Text moneyText;
    public GameObject product;

    void Start()
    {

        strippedString = (moneyText.text).Replace(",", ".").Replace("R$", "");

    }

    void OnMouseDown()
    {
        strippedString = (moneyText.text).Replace(",", ".").Replace("R$", "");
        money = float.Parse(strippedString);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 5.0f))
            {
                sub = money - value;

                if (sub < 0)
                {

                }
                else
                {
                    money = sub;
                    product.SetActive(false);
                }
            }
        }

        moneyText.text = "R$" + money.ToString("0");
    }

}
