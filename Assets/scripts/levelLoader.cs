using UnityEngine;
using System.Collections;

public class levelLoader : MonoBehaviour {

	private bool zone; //to know if player is in the zone

	public string levelLoad;

	// Use this for initialization
	void Start () {
		zone = false; //as player is not in zone

	
	}
	
	// Update is called once per frame
	void Update () {
		//entering new level 
		if (Input.GetKeyDown (KeyCode.W) && zone) {
			Application.LoadLevel(levelLoad); //immediate load level
		}
	}

	void OnTriggerEnter2D(Collider2D other)//finds what has enter the level zone
	{
		if (other.name == "Player") {

			zone = true; //the player is in the zone
		}
	}

	//to avoid if a player wants to return back instead of entering the zone
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.name == "Player") {
			//player must press w to enter new level
			zone = false; 
		}
	}
}
