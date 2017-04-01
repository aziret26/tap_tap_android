using UnityEngine;
using System.Collections;

public class BGScroller : MonoBehaviour {
	
	public float timeLeft;
	
	private Color targetColor;
	private Vector3 startPosition;
	private Color[] colors;

	// Use this for initialization
	void Start () {
		colors = new Color[4];
		colors [0] = Color.cyan;
		colors [1] = Color.yellow;
		colors [2] = Color.green;
		colors [3] = Color.magenta;
		targetColor = colors[Random.Range(0,1000)%4];
	}
	
	// Update is called once per frame
	void Update () {

		//changes color
		if (timeLeft <= Time.deltaTime)
		{
			// transition complete
			// assign the target color
			GetComponent<Renderer>().material.color = targetColor;
			
			// start a new transition
			targetColor = getRandomColor();
			timeLeft = 2.0f;
		}
		else
		{
			// transition in progress
			// calculate interpolated color
			GetComponent<Renderer>().material.color = Color.Lerp(GetComponent<Renderer>().material.color, targetColor, Time.deltaTime / timeLeft);
			
			// update the timer
			timeLeft -= Time.deltaTime;
		}
	}

	private Color getRandomColor(){
		int rand = Random.Range(0,1000)%4;
		return colors[rand];
	}
}
