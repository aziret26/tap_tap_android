using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	GameLogic gamelogic;

	// Use this for initialization
	void Start () {
		gamelogic = Camera.main.GetComponent<GameLogic> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnMouseDown(){  
		if (gameObject.name == "play") {
			Debug.Log("Play");
			gamelogic.gameStart();

		} else if (gameObject.name == "restart") {
			Application.LoadLevel(0);
			Debug.Log("Restart");
		} else if (gameObject.name == "pause") {
			Debug.Log("pause");
			gamelogic.gamePause();
		}
	}
}
