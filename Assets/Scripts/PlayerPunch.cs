using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunch : MonoBehaviour {

	public float punchpower;
	public float powerAddAttack, powerAddDefense;
	public float knockback;
	public float powerValue;
	public Transform opponent;
	public AudioSource audio;
	public AudioClip smolslap;
	public GameObject debris, player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Opponent")) {
			opponent.GetComponent<MainOpponent_Controller> ().newhealth -= punchpower;
			player.GetComponent<Player_Controller> ().currentpower += powerAddAttack;
			opponent.GetComponent<MainOpponent_Controller> ().currentpower += powerAddDefense;
			Debug.Log ("Punch!");
			audio.PlayOneShot (smolslap);

			if (gameObject.name == "PunchTriggerR") {

				opponent.GetComponent<Rigidbody> ().AddForce (Vector3.right * knockback, ForceMode.Impulse);
				GameObject DebrisClone = Instantiate (debris, opponent.position, Quaternion.identity);

			} else if (gameObject.name == "PunchTriggerL") {

				opponent.GetComponent<Rigidbody> ().AddForce (Vector3.left * knockback, ForceMode.Impulse);
				GameObject DebrisClone = Instantiate (debris, opponent.transform.position, Quaternion.identity);

			}
		}
	}
}
