﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public GameObject positionLeft,positionRight;
	private int position;
	private bool isMoving;
	public Rigidbody2D playerContainer;
	// Use this for initialization
	void Start () {
			position = 1;
			playerContainer.transform.position = positionLeft.transform.position;
			isMoving = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (isMoving) {
			if(position == 1 && playerContainer.transform.position.x <= positionLeft.transform.position.x){
				playerContainer.velocity = transform.right  * 0;
				playerContainer.transform.position = positionLeft.transform.position;
				isMoving = false;
			}
			if(position == 0 && playerContainer.transform.position.x >= positionRight.transform.position.x){
				playerContainer.velocity = transform.right  * 0;
				playerContainer.transform.position = positionRight.transform.position;
				isMoving = false;
			}
			gameObject.transform.position = playerContainer.transform.position;
		}
		if (Input.GetButtonDown ("Fire1")) {
			if(position == 0){
				position = 1;
				//transform.position = positionLeft.transform.position;
				playerContainer.velocity = -playerContainer.transform.right * 20;
				isMoving =true;
			}else{
				position = 0;
				//gameObject.transform.position = positionRight.transform.position;
				playerContainer.velocity = playerContainer.transform.right * 20;
				isMoving = true;
			}
		}
	}
}
