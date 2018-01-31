using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_ManagementPlayer : MonoBehaviour {

	public AudioSource audio;

	[Space]
	[Header("Pencil")]
	public AudioClip pencilWin;
	public AudioClip pencilPunch;
	public AudioClip pencilSpecial;
	public AudioClip pencilDies;

	[Space]
	[Header("Woody")]
	public List<AudioClip> woodyPunch;

	//PENCIL
	public void PencilWin(){

		audio.PlayOneShot (pencilWin);

	}
	public void PencilPunch(){

		audio.PlayOneShot (pencilPunch);

	}
	public void PencilSpecial(){

		audio.PlayOneShot (pencilSpecial);

	}
	public void PencilDies(){

		audio.PlayOneShot (pencilDies);

	}

	//WOODY
	public void WoodyPunch(){

		int randomize = Random.Range (0, woodyPunch.Count);
		AudioClip punch = woodyPunch [randomize];
		audio.PlayOneShot (punch);

	}
}
