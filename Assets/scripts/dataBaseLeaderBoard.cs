using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dataBaseLeaderBoard : MonoBehaviour {
	
	private string secretKey = "secretKey"; // Edit this value and make sure it's the same as the one stored on the server
	public string highscoreURL = "http://paddygriffin.cloudapp.net/display.php"; //be sure to add a ? to your url
	public string name = "";
	public int score;
	public InputField Field;
	public Button Submit;
	

	public GameObject scoreList;
	
	// Use this for initialization
	void Start () {
		StartCoroutine(HighScoreMenu());
	}
	
	IEnumerator HighScoreMenu()
	{
		scoreList.GetComponent<Text>().enabled = true;//Enables Score display
		scoreList.GetComponent<Text>().text = "Loading Scores";
		WWW hs_get = new WWW(highscoreURL);
		yield return hs_get;
		
		if (hs_get.error != null)
		{
			print("There was an error getting the high score: " + hs_get.error);
		}
		else
		{
			scoreList.GetComponent<Text>().text = hs_get.text; // this is a GUIText that will display the scores in game.
		}
	}
}