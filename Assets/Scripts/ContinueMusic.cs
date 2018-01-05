using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		GameObject.FindGameObjectWithTag("Music").GetComponent<DontDestroyMusic>().PlayMusic();

	}
}
