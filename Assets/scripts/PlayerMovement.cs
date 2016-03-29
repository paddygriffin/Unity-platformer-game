using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	//variables
	public float speed;
	public float jump;

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

		if(Input.GetKey (KeyCode.D))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
		}

		if(Input.GetKey (KeyCode.A))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
		}
	
	}
}
