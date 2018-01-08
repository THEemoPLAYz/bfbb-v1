using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_ManagementOpponent : MonoBehaviour {

	public AudioSource audio;

	[Space]
	[Header("David")]
	public AudioClip davidAttack;
	public AudioClip davidLose;

	//DAVID
	public void DavidAttack(){

		if (!audio.isPlaying) {
			audio.PlayOneShot (davidAttack);
		}
	}
	public void DavidLose(){

		audio.PlayOneShot (davidLose);

	}
}
