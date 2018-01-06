using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSound : MonoBehaviour {

	public AudioSource audio;
	public AudioClip pencil;

	public void Pencil(){

		audio.PlayOneShot (pencil);

	}
}
