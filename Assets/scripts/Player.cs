using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private Rigidbody2D myrigidbody;
	[SerializeField]
	private float movementspeed = 10f;
	[SerializeField]
	private float jumpheigt = 10f;private bool facing = true;
	private float horizontal;
	

	//----mine
	private Rigidbody2D rigidbody2d;

	void Start ()
	{
		myrigidbody = GetComponent<Rigidbody2D> ();
	}
	void FixedUpdate ()
	{
		horizontal = Input.GetAxis ("Horizontal");
		myrigidbody.velocity = new Vector2 (horizontal * movementspeed, myrigidbody.velocity.y);
	
		//--------------------------------
		if (horizontal > 0 && !facing) 
		{
			Flip ();
		}
		else if (horizontal < 0 && facing) 
		{
			Flip ();
		}
	}
	private void Flip ()
	{
		facing = !facing;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	//-------------------

	private void OnTriggerEnter2D(Collider2D jumpPad)
	{
		if (jumpPad.gameObject.tag == "jumpPad")
		{
			float jumpVelocity = 20f;
			Debug.Log("jump");
			myrigidbody.velocity = Vector2.up * jumpVelocity;
		}

	}
}