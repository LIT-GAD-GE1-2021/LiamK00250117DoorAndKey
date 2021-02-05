using UnityEngine;
using System.Collections;

/*
 * This is a really simple MovementController. It works fine for horizontal movement
 * but needs work for jumps etc
 */
public class MovementController: MonoBehaviour {
	
	private Rigidbody2D theRigidBody;
	public float maxHorixontalSpeed;
	private float speedMultiplier;


    

	// Use this for initialization
	void Start() 
	{
		theRigidBody = GetComponent<Rigidbody2D>();
	}

	// Please be aware of the difference between Update and FixedUpdate
	void Update()
	{
		// Get the value of the Horizontal axis (a value between -1 and 1)
		speedMultiplier = Input.GetAxis ("Horizontal");
	}

	void FixedUpdate()
	{
		// Set the velocity of the object
		theRigidBody.velocity = new Vector2 (maxHorixontalSpeed * speedMultiplier, theRigidBody.velocity.y);
	}


	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == "Key")
		{

			LevelManager.instance.KeyGet();
			Destroy(collision.gameObject);
			

		}



	}


}

