using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	public int speed;
	private Color[] colors;
	public GameObject explosion;

	void Start(){
		colors = new Color[3];
		colors[0] = new Color(160,160,160);
		colors[1] = Color.red;
		colors[2] = new Color(36,36,150);
		renderer.material.color = getRandomColor();
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
			Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (gameObject);
			Destroy (explosion,1);
		}else {
			Destroy(gameObject);
		}
		//Debug.Log ("Trigger: "+other.tag);
	}
	void destroyExplosion(){

	}

}
