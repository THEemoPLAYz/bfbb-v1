using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSelections : MonoBehaviour {

	public GameObject playerChar, opponentChar, canvas;
	public string playerselectedChar, opponentselectedChar;
	public int playerselectedControl, opponentselectedControl;

	// Use this for initialization
	void Awake() {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	public void SetCharacter(){

		if (canvas.GetComponent<CharacterSelect_Controller> ().selectingPlayer) {

			playerselectedChar = playerChar.GetComponent<Image> ().sprite.name;

		} else {

			opponentselectedChar = opponentChar.GetComponent<Image> ().sprite.name;

		}

	}
	public void SetPlayerControl(int controlIndex){

		playerselectedControl = controlIndex;

	}
	public void SetOpponentControl(int controlIndex){

		opponentselectedControl = controlIndex;

	}
}
