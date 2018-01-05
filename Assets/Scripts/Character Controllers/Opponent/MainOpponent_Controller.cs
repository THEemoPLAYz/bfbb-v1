using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainOpponent_Controller : MonoBehaviour {


	public float currenthealth, newhealth;
	public Slider healthbar;
	public AnimationClip hurt;
	public Animation healthanim;
	public Animator anim;

	// Use this for initialization
	void Start () {

		currenthealth = 1f;
		newhealth = 1f;

	}
	
	// Update is called once per frame
	void Update () {

		//healthcheck
		if (currenthealth != newhealth) {

			healthbar.value = newhealth;
			currenthealth = newhealth;
			healthanim.clip = hurt;
			healthanim.Play ();
		}
		if (currenthealth == 0f) {

			anim.SetTrigger ("Death");

		}

}
}
