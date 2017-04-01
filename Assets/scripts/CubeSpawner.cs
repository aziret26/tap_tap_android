﻿using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {

	public Rigidbody obj;
	public float time;

	public GameObject leftSpawner;
	public GameObject rightSpawner;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawn",time,time);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int randomSpawner(){
		int value = Random.Range (0,100);
		return value;
	}

	void spawn () {
		int num = randomSpawner ();
		if (num % 2 == 0) {
			Rigidbody objClone = (Rigidbody)Instantiate (obj, leftSpawner.transform.position, leftSpawner.transform.rotation);
		} else {
			Rigidbody objClone = (Rigidbody)Instantiate (obj, rightSpawner.transform.position, rightSpawner.transform.rotation);
		}
		// You can also acccess other components / scripts of the clone
	}
}
