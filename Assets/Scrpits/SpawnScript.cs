using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public float AsteroidLargeSpawnTime = 1f;
	public Transform asteroidTest;


	private float largeSpawnTime;
	// Use this for initialization
	void Start () {
		largeSpawnTime = AsteroidLargeSpawnTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (largeSpawnTime <= 0) {
			SpawnAsteroid();
			largeSpawnTime = AsteroidLargeSpawnTime;
		}
		largeSpawnTime -= Time.deltaTime;

	}

	void SpawnAsteroid(){
		float x = Random.Range(0, Screen.width);
		float y = Screen.height;
		Vector3 tempVector = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 10));
		tempVector.y += 5;
		//Debug.Log ("Astroid Z " + tempVector.z + "");

		Instantiate (asteroidTest, tempVector, Quaternion.identity);
	}
}
