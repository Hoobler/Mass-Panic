using UnityEngine;
using System.Collections;

public class ColliderScript : MonoBehaviour {

	void  OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Collider Trigger");
		if (collider.tag == "Asteroid") {
			//Checkout how send message works!
			EventManager.TriggerAddScore(1);
			collider.gameObject.GetComponent<AsteroidScript>().Destroy(1f);
		}
	}
}
