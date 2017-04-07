using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {
	
	public GameObject spawner,player,hud;
	private bool isStarted;
	public GUITexture pause,play,restart;

	// Use this for initialization
	void Start () {
		isStarted = false;
		spawner.SetActive (false);
		player.SetActive (false);
		hud.SetActive (false);
		pause.enabled = false;
		restart.enabled = false;
		play.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	public void gameStart(){
		isStarted = true;
		spawner.SetActive(true);
		player.SetActive (true);
		hud.SetActive (true);
		pause.enabled = true;
		restart.enabled = false;
		play.enabled = false;
	}

	public void gamePause(){
		isStarted = false;
		spawner.SetActive (false);
		foreach(Transform child in spawner.transform){
			child.gameObject.SetActive(false);
		}
		player.SetActive (false);
		hud.SetActive (true);
		pause.enabled = false;
		restart.enabled = true;
		play.enabled = true;
	}

	public void gameRestart(){
		Application.LoadLevel(2);
	} 

}
