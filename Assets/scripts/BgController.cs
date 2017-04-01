using UnityEngine;
using System.Collections;

public class BgController : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Debug.Log ("Changing color for Hey");
		InvokeRepeating ("changeWallColor",0,2);
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void changeWallColor(){
		int c1 = Random.Range (0, 255),diff = Random.Range(50,100);

		int c2 = c1, c3 = c1 + diff > 255 ? c1 - diff : c1 + diff;
		Debug.Log ("Changing color for "+c1+" "+c2+" "+c3);
		Renderer rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find("Specular");

		rend.material.SetColor("_SpecColor", new Color(c1,c2,c3,1));
	}
}
