using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentPunch : MonoBehaviour {

	public float punchpower;
	public float powerAddAttack,powerAddDefense;
	public float knockback;
	public Transform player;
	public AudioSource audio;
	public AudioClip smolslap;
	public GameObject debris, opponent;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Player")) {
			player.GetComponent<Player_Controller> ().newhealth -= punchpower;
			opponent.GetComponent<MainOpponent_Controller> ().currentpower += powerAddAttack;
			player.GetComponent<Player_Controller> ().currentpower += powerAddDefense;
			Debug.Log ("Punch!");
			audio.PlayOneShot (smolslap);

			if (gameObject.name == "PunchTriggerR") {

				player.GetComponent<Rigidbody> ().AddForce (Vector3.right * knockback, ForceMode.Impulse);
				GameObject DebrisClone = Instantiate (debris, player.position, Quaternion.identity);

			} else if (gameObject.name == "PunchTriggerL") {

				player.GetComponent<Rigidbody> ().AddForce (Vector3.left * knockback, ForceMode.Impulse);
				GameObject DebrisClone = Instantiate (debris, player.position, Quaternion.identity);

			}
		}
	}
}
