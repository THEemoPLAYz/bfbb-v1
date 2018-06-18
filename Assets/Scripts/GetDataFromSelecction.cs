using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDataFromSelecction : MonoBehaviour {
    
	GameObject selectionData;
	public GameObject player, opponent;

	// Use this for initialization
	void Start () {

        selectionData = GameObject.FindGameObjectWithTag("SelectionData");
        Player1Selection ();
		Player2Selection ();
		Destroy (selectionData);

	}

	public void Player1Selection(){

        string player1char = selectionData.GetComponent<CharacterSelect_StorageDump> ().selectedChar1;
        int controlIndex = selectionData.GetComponent<CharacterSelect_StorageDump> ().selectedController1;

		if (controlIndex == 1) {

			MonoBehaviour control = player.GetComponent(System.Type.GetType((player1char + "_ControllerPlayer").ToString())) as MonoBehaviour;
			control.enabled = true;

		} else if (controlIndex == 2) {

			MonoBehaviour control = player.GetComponent(System.Type.GetType((player1char + "_ControllerAI").ToString())) as MonoBehaviour;
			control.enabled = true;

		}

	}

	public void Player2Selection(){
        
        string player2char = selectionData.GetComponent<CharacterSelect_StorageDump> ().selectedChar2;
		int controlIndex = selectionData.GetComponent<CharacterSelect_StorageDump> ().selectedController2;

		if (controlIndex == 1) {

			MonoBehaviour control = opponent.GetComponent(System.Type.GetType((player2char + "_ControllerPlayer").ToString())) as MonoBehaviour;
			control.enabled = true;

		} else if (controlIndex == 2) {

			MonoBehaviour control = opponent.GetComponent(System.Type.GetType((player2char + "_ControllerAI").ToString())) as MonoBehaviour;
			control.enabled = true;

		}
}

}
