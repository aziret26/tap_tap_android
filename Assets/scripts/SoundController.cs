using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {

	private AudioSource source;
	public AudioClip touchSound, collision;
	

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayTouchSound(){
		source.PlayOneShot (touchSound, 8.0f);
	}

	public void PlayCollisionSound(){
		source.PlayOneShot (collision, 8.0f);
	}
}
