using UnityEngine;
using System.Collections;


[System.Serializable]
public class Boundary
{
	public float xMin, xMax, leftMax, rightMin;
}

public class PlayerController : MonoBehaviour {
	
	public float speed;
	public Boundary boundary;
	
	private Transform leftBall;
	private Transform rightBall;

	private Vector3 DEFAULT_MOVEMENT;

	private Rigidbody leftRb;
	private Rigidbody rightRb;

	void Start () {

		leftBall = gameObject.transform.GetChild (0); 
		leftRb = leftBall.gameObject.GetComponent<Rigidbody> ();

		rightBall = gameObject.transform.GetChild (1);
		rightRb = rightBall.gameObject.GetComponent<Rigidbody> ();

		DEFAULT_MOVEMENT = new Vector3 (1, 0.0f, 0.0f);
	}


	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		
		if (moveHorizontal < 0.0f) {
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
			leftRb.velocity = movement * speed;
			rightRb.velocity = movement * -speed;
		} else {
			leftRb.velocity = DEFAULT_MOVEMENT * (speed + 2);
			rightRb.velocity = DEFAULT_MOVEMENT * (-speed - 2);
		}
		
		leftBall.position = new Vector3 
			(Mathf.Clamp (leftBall.position.x, boundary.xMin, boundary.leftMax), 0.0f, 0.0f);
		rightBall.position = new Vector3 
			(Mathf.Clamp (rightBall.position.x, boundary.rightMin, boundary.xMax), 0.0f, 0.0f); 

	}


	
	
}
