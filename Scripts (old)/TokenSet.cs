using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Token {
	public enum dir {UP=0, DOWN, LEFT, RIGHT};

	public class token {
		public dir direction;
		public float positionX;
	}
	public class TokenSet : MonoBehaviour {

		public string[] directionTags = new string [] {"token (up)", "token (down)","token (left)", "token (right)"};

		//int noOfToken;
		token[] tokenList;
		//List<token> tokenList = new List<token>(8);
		int[] directionList;
		float[] positionList;
		GameObject[] tokenTemplate;

		public TokenSet(int[] directions, float[] positions, GameObject[] templates) {
			directionList = directions;
			positionList = positions;
			tokenTemplate = templates;
		}

		public void GenerateToken(int tokenIndex) {
			/*GameObject newToken = Instantiate(tokenTemplate[(int)newTokenInfo.direction], new Vector3(0, 40, 3.2f), Quaternion.identity);
			newToken.transform.position = new Vector3(0, 40, newTokenInfo.positionX);
			*/
			GameObject newToken = Instantiate(tokenTemplate[directionList[tokenIndex]], new Vector3(positionList[tokenIndex], 40, 0), Quaternion.identity);
			newToken.tag = directionTags[directionList[tokenIndex]];
			newToken.SetActive(true);
		}
	}
}

