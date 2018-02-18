using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDataFromSelecction : MonoBehaviour {

	GameObject selectionData;
	public GameObject player, opponent;

	// Use this for initialization
	void Start () {

		Player1Selection ();
		Player2Selection ();

	}

	public void Player1Selection(){

		selectionData = GameObject.FindGameObjectWithTag("SelectionData");
		string player1char = selectionData.GetComponent<SaveSelections> ().playerselectedChar;
		int controlIndex = selectionData.GetComponent<SaveSelections> ().playerselectedControl;

		string controlComponent;

		if (controlIndex == 1) {

			MonoBehaviour control = player.GetComponent(System.Type.GetType((player1char + "_ControllerPlayer").ToString())) as MonoBehaviour;
			control.enabled = true;

		} else if (controlIndex == 2) {

			MonoBehaviour control = player.GetComponent(System.Type.GetType((player1char + "_ControllerAI").ToString())) as MonoBehaviour;
			control.enabled = true;

		}

	}

	public void Player2Selection(){

		selectionData = GameObject.FindGameObjectWithTag("SelectionData");
		string player2char = selectionData.GetComponent<SaveSelections> ().opponentselectedChar;
		int controlIndex = selectionData.GetComponent<SaveSelections> ().opponentselectedControl;

		string controlComponent;

		if (controlIndex == 1) {

			MonoBehaviour control = opponent.GetComponent(System.Type.GetType((player2char + "_ControllerPlayer").ToString())) as MonoBehaviour;
			control.enabled = true;

		} else if (controlIndex == 2) {

			MonoBehaviour control = opponent.GetComponent(System.Type.GetType((player2char + "_ControllerAI").ToString())) as MonoBehaviour;
			control.enabled = true;

		}
}
}
