using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour {

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Vertical");
        //float moveVertical = Input.GetAxis ("Horizontal");

        //Vector3 movement = new Vector3 (moveHorizontal, 0.0f, -(moveVertical));
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        //rigidbody.velocity = movement;
        rigidbody.AddForce(moveHorizontal, 0, 0, ForceMode.Acceleration);

    }

}
