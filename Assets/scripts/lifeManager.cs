using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class lifeManager : MonoBehaviour {

	//public int startingLives;
	private int lifeCounter;

	private Text theText;

	public GameObject gameOver;

	public PlayerMovement player;


	// Use this for initialization
	void Start () {
		theText = GetComponent<Text>();//find text object and assaign it

		//lifeCounter = startingLives;     //using playprefs instead carry info
		lifeCounter = PlayerPrefs.GetInt ("PlayerCurrentLives");

		player = FindObjectOfType<PlayerMovement> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (lifeCounter <= 0) {

			gameOver.SetActive(true);
			player.gameObject.SetActive(false);
		}



		theText.text = " " + lifeCounter;
	
	}
	

	public void TakeLife()
	{
		lifeCounter--;
		PlayerPrefs.SetInt ("PlayerCurrentLives", lifeCounter);
	}
}
