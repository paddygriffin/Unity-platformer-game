using UnityEngine;
using System.Collections;

public class menuSelect : MonoBehaviour {

	public string startlevel;

	public int playerLives;

	//functions for each button
	public void NewGame()
	{
		Application.LoadLevel (startlevel);

		PlayerPrefs.SetInt ("PlayerCurrentLives", playerLives);//stored values
	}
	
	public void QuitGame()
	{
		Debug.Log ("Game exiteded");
		Application.Quit ();
	}
}
