using UnityEngine;
using System.Collections;

public class menuSelect : MonoBehaviour {

	public string startlevel;

	public int playerLives;//trying to have the lives throughout the whole game

	//functions for each button
	public void NewGame()
	{
		Application.LoadLevel (startlevel);
		PlayerPrefs.SetInt ("PlayerCurrentLives", playerLives);//stored values

		PlayerPrefs.SetInt ("CurrentPlayerScore", 0);


	}
	
	public void QuitGame()
	{
		Debug.Log ("Game exiteded");
		Application.Quit ();
	}
}
