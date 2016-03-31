using UnityEngine;
using System.Collections;

public class playerDestruction : MonoBehaviour {

	public levelManager levelManage;

	private lifeManager lifeSystem;

	// Use this for initialization
	void Start () {
		levelManage = FindObjectOfType<levelManager> (); // finds any object with levelmanager
		lifeSystem = FindObjectOfType<lifeManager> ();
	}
	
	// Update is called once per frame
	void Update () {


	}


	void OnTriggerEnter2D(Collider2D other){
		//detects when player enters a triger zone
		if (other.name == "Player") {
			levelManage.RespawnPlayer();//calling the respawn player
			lifeSystem.TakeLife();

		}
	}
}
