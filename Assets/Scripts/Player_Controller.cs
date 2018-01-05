using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour {

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

	//Right = 1
	//Left = -1

	void Update () {

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

