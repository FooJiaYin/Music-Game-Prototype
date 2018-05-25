using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Token;

public class TokenBirth : MonoBehaviour {

	bool start;
	float startTime;
	int tokenIndex = 0;

	/* Set tokens information for the song (Donot set in TokenSet!!) */
	//All the following default values can be altered in Unity,
	public int NoOfToken = 10;
	public int[] directionList = new int[10] {0,1,2,3,1,0,1,0,3,2};
	public int[] positionList = new int[10] {1, 2, 1, 2, 2, 1, 2, 1, 1, 1};
	public float[] timeList = new float[10] {5,8,13,15,18,21,24,27,30,33};
	public GameObject[] tokenTemplate = new GameObject[4];

	TokenSet localSet;

	// Use this for initialization
	void Start () {
		start = false;
		startTime = 0.0f;
		/* Generate TokenSet base on the information and the template (TokenSet) */
		localSet = new TokenSet(NoOfToken, directionList, positionList, tokenTemplate);
	}
	
	// Update is called once per frame
	void Update () {
		/* Log the starting time */
		if(Input.GetKeyDown("space") && !start) { //press SPACE to start game
			start = true;
			startTime = Time.realtimeSinceStartup;
		}
		/* Determine the time to drop next token */
		//I'm considering putting the code below to TokenSet
		if(tokenIndex<NoOfToken && start && (Time.realtimeSinceStartup-startTime-Time.deltaTime >= timeList[tokenIndex])) {
			localSet.GenerateToken(tokenIndex);
			tokenIndex++;
			Debug.Log("Generate token.");
		}
	}
}