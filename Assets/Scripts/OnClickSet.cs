using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickSet : MonoBehaviour {

    public void SetActive(GameObject gameObject)
    {

        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }

    }

}
