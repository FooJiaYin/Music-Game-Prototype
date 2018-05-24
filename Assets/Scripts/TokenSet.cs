using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Token {

	/* A template of information of set of tokens (for each song) */
	public class TokenSet : MonoBehaviour {

		public string[] directionTags = new string [] {"token (up)", "token (down)","token (left)", "token (right)"};

		int[] directionList;
		float[] positionList;
		GameObject[] tokenTemplate; //drag GameObject here

		/* Class Constructor */
		public TokenSet(int[] directions, float[] positions, GameObject[] templates) {
			directionList = directions;
			positionList = positions;
			tokenTemplate = templates;
		}

		/* Atrieve information from Lists and Generate each single token */
		public void GenerateToken(int tokenIndex) {GameObject newToken = Instantiate(tokenTemplate[directionList[tokenIndex]], new Vector3(positionList[tokenIndex], 40, 0), Quaternion.identity);
			newToken.tag = directionTags[directionList[tokenIndex]];
			newToken.SetActive(true);
		}
	}
}

