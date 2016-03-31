using UnityEngine;
using System.Collections;

public class menuSelect : MonoBehaviour {

	public string startlevel;


	//functions for each button
	public void NewGame()
	{
		Application.LoadLevel (startlevel);
	}
	
	public void QuitGame()
	{
		Debug.Log ("Game exiteded");
		Application.Quit ();
	}
}
