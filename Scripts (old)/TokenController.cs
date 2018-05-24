using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenController : MonoBehaviour {
	//public GameObject ceiling;
	public float tokenSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate () {
		Vector3 tokenSpeed3D = new Vector3 (0.0f, -tokenSpeed, 0.0f);
		transform.position += tokenSpeed3D * Time.deltaTime;
	}
}
