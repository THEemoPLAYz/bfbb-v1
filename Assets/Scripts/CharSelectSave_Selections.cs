using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelectSave_Selections : MonoBehaviour {

    public GameObject canvas;
    public string selectedChar1, selectedChar2;
    public int selectedController1, selectedController2;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}

    // Update is called once per frame
    public void CharSelect_SaveSelections() {

        selectedChar1 = canvas.GetComponent<CharacterSelect_ControllerNew>().selectedChar1;
        selectedChar2 = canvas.GetComponent<CharacterSelect_ControllerNew>().selectedChar2;
        selectedController1 = canvas.GetComponent<CharacterSelect_ControllerNew>().selectedController1;
        selectedController2 = canvas.GetComponent<CharacterSelect_ControllerNew>().selectedController2;

    }
}
