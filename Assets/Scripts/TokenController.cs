using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TokenController : MonoBehaviour {
	
	public float tokenSpeed;
	public Text scoreBoard;
	ScoreDisplay scorePort;
	public KeyCode key;
	bool inCollision;

	// Use this for initialization
	void Start () {
		scorePort = scoreBoard.GetComponent<ScoreDisplay>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(key) && inCollision) {
			Debug.Log(this.gameObject + "bingo");
            scorePort.AddScore();	
			ExitCollision(inCollision);
        }
	}

	void FixedUpdate () {
		Vector3 tokenSpeed3D = new Vector3 (0.0f, -tokenSpeed, 0.0f);
		transform.position += tokenSpeed3D * Time.deltaTime;
	}

	void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Ground") {
        	inCollision = true;
            //Debug.Log(this.gameObject + " collid with " + other.gameObject.name + " inCollision: " + inCollision);
		}
    }

    void OnTriggerExit(Collider other) {
		//Debug.Log(this.gameObject + "Exit. inCollision " + inCollision);
		ExitCollision(inCollision);
    }

	void ExitCollision(bool trigger) {
		if(trigger) {
			//Debug.Log("Destroying " + this.gameObject.name);
            this.gameObject.SetActive(false); //you can also use destroy  		
        	inCollision = false;    
		}
	}
}
