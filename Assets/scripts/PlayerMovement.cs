using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	//variables
	public float speed;
	public float jump;
	private float moveVelocity;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;//will show if player hits ground

	private bool doubleJump;

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate() {
		
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}
	
	// Update is called once per frame
	void Update () {
		if (grounded) {
			doubleJump = false;
		}

		
		if(Input.GetKeyDown (KeyCode.Space) && grounded) //player can now only jump when on the ground
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
		}

		//double jump
		if (Input.GetKeyDown (KeyCode.Space) && !doubleJump &&!grounded) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
			doubleJump = true;//able to jump twice 
		}

		moveVelocity = 0f; //nothing being pressed will stop the player

		if(Input.GetKey (KeyCode.D))
		{
			//GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = speed;
		}

		if(Input.GetKey (KeyCode.A))
		{
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -speed;
		}

		GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
	
	}
}
