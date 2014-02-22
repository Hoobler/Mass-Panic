using UnityEngine;
using System.Collections;

public class GamePlayScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Began) {
				// Construct a ray from the current touch coordinates
				Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
				RaycastHit2D hit;
				if (hit = Physics2D.Raycast (touchPos, Vector2.zero, 10,1 << LayerMask.NameToLayer("TouchLayer"))) {
					if(hit.collider.transform.parent.gameObject.tag == "Asteroid"){
						Debug.Log("Destroy");
						hit.collider.transform.parent.gameObject.GetComponent<AsteroidScript>().Destroy();
					}
					Debug.Log("Ray hit!!");
				}
			}
		}

		if(Input.GetMouseButton(0))
		{
			Debug.Log( "Raycasting now !" );
			
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit;
			
			if(hit = Physics2D.Raycast(mousePos, Vector2.zero, 10, 1 << LayerMask.NameToLayer("TouchLayer"))) // added distance of Mathf.Infinity
			{

				Debug.Log("Name: " + hit.collider.transform.parent.gameObject);
				if(hit.collider.transform.parent.gameObject.tag == "Asteroid"){
					Debug.Log("Destroy");
					hit.collider.transform.parent.gameObject.GetComponent<AsteroidScript>().Destroy();
				}
				Debug.Log("Ray hit : " + hit.collider.gameObject.name);
			}
		}
	}
}
