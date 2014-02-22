using UnityEngine;
using System.Collections;

public class AsteroidScript : MonoBehaviour {

	public void Destroy(){
		//Debug.Log ("Asteroid Death!");
		Destroy (gameObject);
	}

	public void Destroy(float time){
		Destroy (gameObject, time);
	}

	public void AddForce(Vector2 force){
		transform.rigidbody2D.AddForce (force);
	}
}
