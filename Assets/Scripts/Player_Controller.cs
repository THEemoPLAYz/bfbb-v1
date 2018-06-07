using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour {

	public float currentHealth, newHealth, barUpdateSpeed;
	public float currentPower;
	public bool testForOof;
	public GameObject bar, opponent, oof;
    public GameObject pencilDebris, woodyDebris, spongyDebris;
    public GameObject currentDebris;
	public Slider healthbar, powerbar;
	public AnimationClip hurt;
	public Animation healthanim;
	public Animator anim, powerAnim;
	public AudioSource music;
    public Transform playerSpawn;

	// Use this for initialization
	void Start () {

		currentPower = 0f;
		currentHealth = 1f;
		newHealth = 1f;
		testForOof = false;

        if (GetComponent<Pencil_ControllerPlayer>().enabled == true){

            currentDebris = pencilDebris;

        } else if (GetComponent<Woody_ControllerPlayer>().enabled == true){

            currentDebris = woodyDebris;

        } else if (GetComponent<Spongy_ControllerPlayer>().enabled == true){

            currentDebris = spongyDebris;

        }

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

			if (testForOof == false) {

				TryGetOof ();

			}
			if (testForOof == true) {
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
	public void TryGetOof(){

		int randomize = Random.Range (1, 100);
		if (randomize == 1) {

			oof.SetActive (true);
			testForOof = true;

		} else {

			testForOof = true;

		}

	}
    public void PlayerSpawnDebris(){
        
        GameObject DebrisClone = Instantiate(currentDebris, playerSpawn.position, Quaternion.identity);
        DebrisClone.SetActive(true);

    }

	}

