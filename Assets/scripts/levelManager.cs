using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class levelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
	private PlayerMovement player;
	

	//losing points
	public int pointLoss;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerMovement> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer()
	{
		Debug.Log ("Player Respawn");
		player.transform.position = currentCheckpoint.transform.position;
		player.GetComponent<Rigidbody2D>().velocity = Vector2.zero; // fixes the players checkpoint
		scoreManager.AddPoint (-pointLoss); //calling scoreManager to takeaway points
	}

	
}
