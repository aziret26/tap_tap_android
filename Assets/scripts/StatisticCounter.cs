using UnityEngine;
using System.Collections;

public class StatisticCounter : MonoBehaviour {
	
	public static int score, health;
	public GUIText ScoreGUI, HealthGUI;

	// Use this for initialization
	void Start () {
		score = 0;
		health = 5;

	}
	
	// Update is called once per frame
	void Update () {
		OnGUI ();
	}

	void OnGUI(){ //вывод инфо(патороны очки)
		ScoreGUI.text = "Score: " + score;
		HealthGUI.text = "Health: "+health;
	}
}