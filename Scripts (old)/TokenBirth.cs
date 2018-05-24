using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Token;

public class TokenBirth : MonoBehaviour {

	bool start;
	float startTime;
	int tokenIndex = 0;
	//public token[] tokenList = new token[8];
	//public List<token> tokenList = new List<token>(8);
	public int[] directionList = new int[10] {0,1,2,3,1,0,1,0,3,2};
	public float[] positionList = new float[10] {3.4f, 2.3f, -2.0f, -1.1f, 3.1f, 0.9f, -0.9f, 0.0f, 8.3f, -4.3f};
	public float[] timeList = new float[10] {5,8,13,15,18,21,24,27,30,33};
	public GameObject[] tokenTemplate = new GameObject[4];

	public TokenSet localSet;

	// Use this for initialization
	void Start () {
		start = false;
		startTime = 0.0f;
		localSet = new TokenSet(directionList, positionList, tokenTemplate);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space") && !start) {
			start = true;
			startTime = Time.realtimeSinceStartup;
		}
		if(start && (Time.realtimeSinceStartup-startTime-Time.deltaTime >= timeList[tokenIndex])) {
			localSet.GenerateToken(tokenIndex);
			tokenIndex++;
		}
	}
}