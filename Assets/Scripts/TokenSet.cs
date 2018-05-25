using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Token {

	/* A template of information of set of tokens (for each song) */
	public class TokenSet : MonoBehaviour {

		public string[] directionTags = new string [4] {"token (up)", "token (down)","token (left)", "token (right)"};
		public float leftPosition, rightPosition;
		//public GameObject mother;
		int noOfToken;
		int[] directionList;
		float[] positionList;
		public float positionY;
		GameObject[] tokenTemplate; //drag GameObject here


		// Use this for initialization
		void Start () {
			
		}

		/* Class Constructor */
		public TokenSet(int size, int[] directions, int[] positions, GameObject[] templates) {
			noOfToken = size;
			directionList = directions;
			positionList = new float[size];
			for(int i=0; i<size; i++) {
				positionList[i] = (positions[i]==1)? leftPosition : rightPosition;
			}
			tokenTemplate = templates;
		}

		/* Atrieve information from Lists and Generate each single token */
		public void GenerateToken(int tokenIndex) {
			//Debug.Log("positionY = " + GetComponent<Transform>().transform.position.y);
			GameObject newToken = Instantiate(tokenTemplate[directionList[tokenIndex]], new Vector3(positionList[tokenIndex], positionY, 0), Quaternion.identity);
			newToken.tag = directionTags[directionList[tokenIndex]];
			newToken.SetActive(true);
			Debug.Log(newToken + "created at " + newToken.transform.position);
		}
	}
}

