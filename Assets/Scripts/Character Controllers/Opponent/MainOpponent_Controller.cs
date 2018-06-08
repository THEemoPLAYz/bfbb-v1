using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainOpponent_Controller : MonoBehaviour {


	public float currentHealth, newHealth, currentPower, barUpdateSpeed;
	public bool testForOof;
	public int random;
	public Slider healthbar, powerbar;
	public GameObject bar, player, oof;
    public GameObject davidDebris;
    public GameObject currentDebris;
	public AnimationClip hurt;
	public Animation healthanim;
	public Animator anim, powerAnim;
	public AudioSource music;
    public Transform opponentCenter;

	// Use this for initialization
	void Start () {

		currentPower = 0f;
		currentHealth = 1f;
		newHealth = 1f;
		testForOof = false;

        if (GetComponent<David_ControllerAI>().enabled == true){

            currentDebris = davidDebris;

        }

	}
	
	// Update is called once per frame
	void Update () {

		powerAnim.SetFloat ("Power", powerbar.value);

		if (powerbar.value != currentPower) {
			
			powerbar.value = Mathf.Lerp (powerbar.value, currentPower, barUpdateSpeed * Time.deltaTime);

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

			if (testForOof == false) {

				TryGetOof ();

			}
			if (testForOof == true) {
				anim.SetTrigger ("Death");
				gameObject.GetComponent<David_ControllerAI> ().enabled = false;
				bar.SetActive (false);
				gameObject.GetComponent<MainOpponent_Controller> ().enabled = false;
				player.GetComponent<Pencil_ControllerPlayer> ().enabled = false;
				music.Stop ();
			}



		}

	}
	public void TryGetOof(){

		int randomize = Random.Range (1, 100);
		if (randomize == 1) {

			random = randomize;
			oof.SetActive (true);
			testForOof = true;

		} else {

			random = randomize;
			testForOof = true;

		}

	}
    public void SpawnOpponentDebris() {

        GameObject DebrisClone = Instantiate(currentDebris, opponentCenter.position, Quaternion.identity);
        DebrisClone.SetActive(true);

    }
}
