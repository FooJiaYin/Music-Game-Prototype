using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Token;

public class TokenReceiver : MonoBehaviour {

	TokenSet localSet;
	public Text scoreText;
	int score;

	// Use this for initialization
	void Start () {
		//TokenBirth localBirth = GetComponent<TokenBirth>();
		//TokenSet localSet = localBirth.localSet;
		score = 0;
		SetScoreText();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("token (up)")) {
			if(Input.GetKey("up")) {
				score++;
			}
		}
		else if(other.gameObject.CompareTag("token (down)")) {
			if(Input.GetKey("down")) {
				score++;
			}
		}
		if(other.gameObject.CompareTag("token (left)")) {
			if(Input.GetKey("left")) {
				score++;
			}
		}
		if(other.gameObject.CompareTag("token (right)")) {
			if(Input.GetKey("right")) {
				score++;
			}
		}
		//Destroy(other, 0.1f);
		other.gameObject.SetActive(false);
		SetScoreText();
	}

	void SetScoreText () {
		scoreText.text = "Score " + score.ToString();
	}
}
