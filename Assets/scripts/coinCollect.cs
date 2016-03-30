using UnityEngine;
using System.Collections;

public class coinCollect : MonoBehaviour {

	//how much coin is worth
	public int points;

	void OnTriggerEnter2D (Collider2D other)
	{
		//only player collects coins 
		if (other.GetComponent<PlayerMovement> () == null)
			return;

		scoreManager.AddPoint (points); //calling scoreManager to add points

		Destroy (gameObject); //remove coin 
	}
}
