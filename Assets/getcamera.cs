using UnityEngine;
using System.Collections;

public class getcamera : MonoBehaviour {
	public GameObject cam;
	public int altura_camera=5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		cam.transform.position = new Vector3( this.transform.position.x, altura_camera, this.transform.position.z);;
	}
}
