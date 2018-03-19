using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour {

	public float currentHealth, newHealth, barUpdateSpeed;
	public float currentPower;
	public GameObject bar, opponent;
	public Slider healthbar, powerbar;
	public AnimationClip hurt;
	public Animation healthanim;
	public Animator anim, powerAnim;
	public AudioSource music;

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

		powerAnim.SetFloat ("Power", currentPower);
		
		if (powerbar.value != currentPower) {

			powerbar.value = Mathf.Lerp (powerbar.value, currentPower, barUpdateSpeed * Time.deltaTime);
		}


		if (healthbar.value != currentHealth) {

			healthbar.value = Mathf.Lerp (healthbar.value, currentHealth, barUpdateSpeed * Time.deltaTime);

		}
		if (currentHealth != newHealth) {

			healthanim.clip = hurt;
			currentHealth = newHealth;
			healthanim.Play ();
		
		}
		if (currentHealth < 0f) {

			gameObject.GetComponent<Player_Controller> ().enabled = false;
			gameObject.GetComponent<Pencil_ControllerPlayer> ().enabled = false;
			gameObject.GetComponent<Woody_ControllerPlayer> ().enabled = false;

			opponent.GetComponent<David_ControllerAI> ().enabled = false;

			anim.SetTrigger ("Death");
			bar.SetActive (false);
			music.Stop ();

		}

	}

	}

