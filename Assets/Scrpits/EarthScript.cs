﻿using UnityEngine;
using System.Collections;

public class EarthScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void  OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Trigger");
		if (collider.tag == "Asteroid") {
			collider.gameObject.GetComponent<AsteroidScript>().Destroy();
		}
	}
}
