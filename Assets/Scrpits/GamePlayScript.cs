using UnityEngine;
using System.Collections;

public class GamePlayScript : MonoBehaviour {

	private int _score = 0;
	private GameObject _asteroid;
	private GUIText _scoreGUI;
	private int _currTouch;
	private RaycastHit2D _hit;

	// Use this for initialization
	void Start () {
		_scoreGUI = GameObject.Find ("GUIScore").guiText;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.touches.Length <= 0){
			//No touches this update;
		}
		else{
			//if there where touches continue this update loop!
			//Loop throu all the touches in this update hurr
			for(int i = 0; i < Input.touchCount; i++){
				//Construct a ray from the current touch
				Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position);

				if(_hit = Physics2D.Raycast (touchPos, Vector2.zero, 10,1 << LayerMask.NameToLayer("TouchLayer"))){
					Debug.Log("Ray hit! gameObject: " + _hit.collider.gameObject.transform.parent.gameObject);
					if (Input.GetTouch(i).phase == TouchPhase.Began) {
						if(_hit.collider.transform.parent.gameObject.tag == "Asteroid"){
							_asteroid = _hit.collider.transform.parent.gameObject;
		//					Debug.Log("Destroy");
		//					hit.collider.transform.parent.gameObject.GetComponent<AsteroidScript>().Destroy();
						}
					}
					if (Input.GetTouch(i).phase == TouchPhase.Moved){
						Vector2 touchDelta = Input.GetTouch(0).deltaPosition / Time.deltaTime;
						if(_asteroid != null){
						_asteroid.GetComponent<AsteroidScript>().AddForce(touchDelta);
						}
					}
				}
			}
	
			if(Input.GetMouseButtonDown(0))
			{
				Debug.Log( "Raycasting now !" );
				
				Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				RaycastHit2D hit;
				
				if(hit = Physics2D.Raycast(mousePos, Vector2.zero, 10, 1 << LayerMask.NameToLayer("TouchLayer"))) // added distance of Mathf.Infinity
				{
	
					Debug.Log("Name: " + hit.collider.transform.parent.gameObject);
					if(hit.collider.transform.parent.gameObject.tag == "Asteroid"){
	//					Debug.Log("Destroy");
	//					hit.collider.transform.parent.gameObject.GetComponent<AsteroidScript>().Destroy();
					}
					Debug.Log("Ray hit : " + hit.collider.gameObject.name);
				}
			}
		}

		UpdateScore ();
	}

	public void AddScore(int score){
		_score += score;
	}

	private void UpdateScore(){
		_scoreGUI.text = _score.ToString ();
	}
}
