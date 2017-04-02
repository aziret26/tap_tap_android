using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public GameObject positionLeft,positionRight;
	private int position;
	// Use this for initialization
	void Start () {
		//if (Random.Range (0, 1000) % 2 == 0) {
			position = 1;
			gameObject.transform.position = positionLeft.transform.position;
/*		} else{
			position = 0;
			gameObject.transform.position = positionRight.transform.position;
		}*/
	}
	
	// Update is called once per frame
	void Update () {
		int fingerCount = 0;
		foreach (Touch touch in Input.touches) {
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
				fingerCount++;
		}
		if (fingerCount > 0){
			//Debug.Log("User has " + fingerCount + " finger(s) touching the screen");
			if(position == 0){
				position = 1;
				gameObject.transform.position = positionLeft.transform.position;
			}else{
				position = 0;
				gameObject.transform.position = positionRight.transform.position;
			}
		}
		if (Input.GetMouseButtonDown (0)) {
			if(position == 0){
				position = 1;
				gameObject.transform.position = positionLeft.transform.position;
			}else{
				position = 0;
				gameObject.transform.position = positionRight.transform.position;
			}
		}
	}
}
