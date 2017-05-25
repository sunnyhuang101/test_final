using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backpackController : MonoBehaviour {

	public float speed = 30f;
	public bool isColli = false;

	private float x = 5f;

	// Use this for initialization
	void Start () {
		//GetComponent<Rigidbody2D> ().AddForce(transform.right * speed);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().AddForce(transform.right * speed);
		if (Input.GetMouseButton(0)){
			//this.
			Debug.Log("keep");
		}
	}

	//void OnCollisionEnter(Collision other)
	//{	
	//	Debug.Log ("Hi");
	//}


	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "enemy") 
		{
			target.gameObject.SetActive (false);
			this.gameObject.SetActive (false);
		}
	
	}


}
