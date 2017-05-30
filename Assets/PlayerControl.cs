using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
            GetComponent<Rigidbody2D>().AddForce(new Vector2(30,0));
        if (Input.GetKey("s"))
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-30, 0));
        if (Input.GetKey("a"))
            GetComponent<Rigidbody2D>().AddTorque(20);
        if (Input.GetKey("d"))
            GetComponent<Rigidbody2D>().AddTorque(-20);
    }
}
