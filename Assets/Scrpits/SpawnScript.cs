using UnityEngine;
using System.Collections;

[System.Serializable]
public class LargeAsteroid{
	public Transform Asteroid;
	public int MediumAsteroids = 0;
	public int SmallAsteroids = 0;
}

[System.Serializable]
public class MediumAsteroid{
	public Transform Asteroid;
	public int MediumAsteroids = 0;
	public int SmallAsteroids = 0;
}

[System.Serializable]
public class SmallAsteroid{
	public Transform Asteroid;
}

public class SpawnScript : MonoBehaviour {

	public float AsteroidLargeSpawnTime = 1f;
	public LargeAsteroid LargeAsteroid;
	public MediumAsteroid MediumAsteroid;
	public SmallAsteroid SmallAsteroid;


	private float largeSpawnTime;
	private int _asteroidCounter;
	private float _y;
	// Use this for initialization
	void Start () {
		largeSpawnTime = AsteroidLargeSpawnTime;
		_y = Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
		if (largeSpawnTime <= 0) {
			_asteroidCounter++;
			SpawnAsteroid();
			largeSpawnTime = AsteroidLargeSpawnTime;
		}
		largeSpawnTime -= Time.deltaTime;
	}

	void SpawnAsteroid(){
		float x = Random.Range(0, Screen.width);
		Vector3 tempVector = Camera.main.ScreenToWorldPoint(new Vector3(x, _y, 10));
		tempVector.y += 5;
		//Debug.Log ("Astroid Z " + tempVector.z + "");
		//Debug info!
		SmallAsteroid.Asteroid.name = "AsteroidNr" + _asteroidCounter;
		Instantiate (SmallAsteroid.Asteroid, tempVector, Quaternion.identity);
	}
}
