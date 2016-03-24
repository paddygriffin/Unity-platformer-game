using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	//variables
	public float speed;
	public float jump;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown (KeyCode.Space))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(0 , jump);
		}

		if(Input.GetKey (KeyCode.D))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(speed , 0);
		}

		if(Input.GetKey (KeyCode.A))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(-speed , 0);
		}
	
	}
}
