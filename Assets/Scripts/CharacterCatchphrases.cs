using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCatchphrases : MonoBehaviour {

	public AudioSource audio;
	public AudioClip pencil, woody, david;

	public void PencilCatchPhrase(){

		audio.PlayOneShot (pencil);

	}
	public void WoodyCatchPhrase(){

		audio.PlayOneShot (woody);

	}
	public void DavidCatchPhrase(){

		audio.PlayOneShot (david);

	}

}
