using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	public int speed;
	private Color[] colors;
	public GameObject explosion;

	private SoundController audio;

	void Start(){
		colors = new Color[3];
		colors[0] = Color.white;
		colors[1] = Color.red;
		colors[2] = Color.cyan;
		renderer.material.color = getRandomColor();
		audio = GameObject.FindGameObjectWithTag("Sound").GetComponent<SoundController>();

	}

	void Update () {
		//moves obstacle down
		rigidbody2D.velocity = transform.forward * speed;
	}
	private Color getRandomColor(){
		int rand = Random.Range(0,1000)%3;
		return colors[rand];
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			GameObject explosion_clon = Instantiate (explosion, gameObject.transform.position, explosion.transform.rotation)as GameObject;
			explosion_clon.GetComponent<Renderer>().material.color = renderer.material.color;
			Destroy (gameObject);
			StatisticCounter.health -= 1;
			audio.PlayCollisionSound();
			if(StatisticCounter.health == 0){
				Instantiate (explosion, other.transform.position, explosion.transform.rotation);
				other.gameObject.SetActive(false);
			}

		}else {
			Destroy(gameObject);
		}
	}
}
