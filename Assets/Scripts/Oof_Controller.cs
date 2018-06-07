using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oof_Controller : MonoBehaviour {

	public AudioSource audioSource;
	
	// Update is called once per frame
	void Update () {
		
		if (!audioSource.isPlaying) {

			gameObject.SetActive (false);

		}
	}
}
