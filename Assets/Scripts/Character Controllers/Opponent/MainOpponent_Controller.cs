using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainOpponent_Controller : MonoBehaviour {


	public float currenthealth, newhealth, currentpower;
	public Slider healthbar, powerbar;
	public GameObject bar, player;
	public AnimationClip hurt;
	public Animation healthanim;
	public Animator anim;
	public AudioSource music;

	// Use this for initialization
	void Start () {

		currentpower = 0f;
		currenthealth = 1f;
		newhealth = 1f;

	}
	
	// Update is called once per frame
	void Update () {

		powerbar.value = currentpower;

		//healthcheck
		if (currenthealth != newhealth) {

			healthbar.value = newhealth;
			currenthealth = newhealth;
			healthanim.clip = hurt;
			healthanim.Play ();
		}
		if (currenthealth < 0f) {

			anim.SetTrigger ("Death");
			gameObject.GetComponent<David_ControllerAI> ().enabled = false;
			bar.SetActive (false);
			gameObject.GetComponent<MainOpponent_Controller>().enabled = false;
			player.GetComponent<Pencil_ControllerPlayer> ().enabled = false;
			music.Stop ();



		}

}
}
