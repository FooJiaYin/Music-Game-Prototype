using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    int scoreValue = 0;
	public int scorePerToken = 1000;
    Text scoreText;
    // Use this for initialization
	void Start () {
		scoreText = GetComponent<Text>();
		scoreValue = 0;  
		UpdateScore();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void AddScore() {
		scoreValue += scorePerToken;
		UpdateScore();
	}

	public void UpdateScore() {
		scoreText.text = "Score " + scoreValue.ToString();
	}
}
