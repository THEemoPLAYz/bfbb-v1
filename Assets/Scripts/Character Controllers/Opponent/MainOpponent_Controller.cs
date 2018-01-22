using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainOpponent_Controller : MonoBehaviour {


	public float currentHealth, newHealth, currentPower, barUpdateSpeed;
	public Slider healthbar, powerbar;
	public GameObject bar, player;
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
	void Update () {
		
		if (powerbar.value != currentPower) {
			powerbar.value = Mathf.Lerp (powerbar.value, currentPower, barUpdateSpeed * Time.deltaTime);
			powerAnim.SetFloat ("Power", powerbar.value);
		}

		//healthcheck

		if (healthbar.value != currentHealth) {

			healthbar.value = Mathf.Lerp (healthbar.value, currentHealth, barUpdateSpeed * Time.deltaTime);

		}
		if (currentHealth != newHealth) {

			healthanim.clip = hurt;
			currentHealth = newHealth;
			healthanim.Play ();

		}
		if (currentHealth < 0f) {

			anim.SetTrigger ("Death");
			gameObject.GetComponent<David_ControllerAI> ().enabled = false;
			bar.SetActive (false);
			gameObject.GetComponent<MainOpponent_Controller>().enabled = false;
			player.GetComponent<Pencil_ControllerPlayer> ().enabled = false;
			music.Stop ();



		}

}
}
