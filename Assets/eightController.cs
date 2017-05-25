using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eightController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(new Vector2 (-8, 0)*Time.deltaTime);
	}
}
