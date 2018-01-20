using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour {

	public float currenthealth, newhealth;
	public float currentpower, newpower;
	public Slider healthbar, powerbar;
	public AnimationClip hurt;
	public Animation healthanim;
	public Animator anim, powerAnim;

	// Use this for initialization
	void Start () {

		currentpower = 0f;
		currenthealth = 1f;
		newhealth = 1f;

	}
	
	// Update is called once per frame

	//Right = 1
	//Left = -1

	void Update () {

		powerbar.value = currentpower;
		powerAnim.SetFloat ("PowerMeter", currentpower);

		if (currenthealth != newhealth) {

			healthanim.clip = hurt;
			healthbar.value = newhealth;
			currenthealth = newhealth;
			healthanim.Play ();

		}
		if (currenthealth == 0f) {

			anim.SetTrigger ("Death");

		}

	}

	}

