using UnityEngine;
using System.Collections;

public class AsteroidScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Destroy(){
		//Debug.Log ("Asteroid Death!");
		Destroy (gameObject);
	}

	public void AddForce(Vector2 force){
		transform.rigidbody2D.AddForce (force);
	}
}
