using UnityEngine;
using System.Collections;

public enum AsteroidType{
	Small, Medium, Large
}

public class AsteroidScript : MonoBehaviour {
	
	public AsteroidType asteroidType;
	
	public void OnDeath(){
		if(asteroidType == AsteroidType.Large){
			
		}
		if(asteroidType == AsteroidType.Medium){
			
		}
	}

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
