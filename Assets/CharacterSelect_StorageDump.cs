using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect_StorageDump : MonoBehaviour {

    public string selectedChar1;
    public int selectedController1;
    public string selectedChar2;
    public int selectedController2;

    // Use this for initialization
    void Start () {

        DontDestroyOnLoad(gameObject);

	}
}
