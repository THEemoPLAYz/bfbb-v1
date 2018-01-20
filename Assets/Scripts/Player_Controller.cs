using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour {

	public float currentHealth, newHealth;
	public float currentPower, newPower;
	public Slider healthbar, powerbar;
	public AnimationClip hurt;
	public Animation healthanim;
	public Animator anim, powerAnim;

	// Use this for initialization
	void Start () {

		currentPower = 0f;
		currentHealth = 1f;
		newHealth = 1f;

	}
	
	// Update is called once per frame

	//Right = 1
	//Left = -1

	void Update () {

		powerbar.value = currentPower;
		powerAnim.SetFloat("Power", powerbar.value);

		if (currentHealth != newHealth) {

			healthanim.clip = hurt;
			healthbar.value = newHealth;
			currentHealth = newHealth;
			healthanim.Play ();

		}
		if (currentHealth == 0f) {

			anim.SetTrigger ("Death");

		}

	}

	}

