using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunch : MonoBehaviour {

	public float punchpower;
	public float powerAddAttack, powerAddDefense;
	public float knockback;
	public float powerValue;
	public Transform opponentSpawn;
	public AudioSource audio;
	public AudioClip smolslap;
	public GameObject opponent, debris, player, cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Opponent")) {
			opponent.GetComponent<MainOpponent_Controller> ().newHealth -= punchpower;
			player.GetComponent<Player_Controller> ().currentPower += powerAddAttack;
			opponent.GetComponent<MainOpponent_Controller> ().currentPower += powerAddDefense;
			audio.PlayOneShot (smolslap);
			cam.GetComponent<Camera_Controller> ().ZoomPunch ();

			if (gameObject.name == "PunchTriggerR") {

				opponent.GetComponent<Rigidbody> ().AddForce (Vector3.right * knockback, ForceMode.Impulse);
				GameObject DebrisClone = Instantiate (debris, opponentSpawn.position, Quaternion.identity);
				DebrisClone.SetActive (true);

			} else if (gameObject.name == "PunchTriggerL") {

				opponent.GetComponent<Rigidbody> ().AddForce (Vector3.left * knockback, ForceMode.Impulse);
				GameObject DebrisClone = Instantiate (debris, opponentSpawn.position, Quaternion.identity);
				DebrisClone.SetActive (true);

			}
		}
	}
}
