using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentPunch : MonoBehaviour {

	public float punchpower;
	public float powerAddAttack,powerAddDefense;
	public float knockback;
	public Transform playerSpawn;
	public AudioSource audio;
	public AudioClip smolslap;
	public GameObject player, debris, opponent, cam;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Player")) {
			
			player.GetComponent<Player_Controller> ().newHealth -= punchpower;
			opponent.GetComponent<MainOpponent_Controller> ().currentPower += powerAddAttack;
			player.GetComponent<Player_Controller> ().currentPower += powerAddDefense;

			audio.PlayOneShot (smolslap);
			cam.GetComponent<Camera_Controller> ().ZoomPunch ();

			if (gameObject.name == "PunchTriggerR") {

				player.GetComponent<Rigidbody> ().AddForce (Vector3.right * knockback, ForceMode.Impulse);
				GameObject DebrisClone = Instantiate (debris, playerSpawn.position, Quaternion.identity);
				DebrisClone.SetActive (true);

			} else if (gameObject.name == "PunchTriggerL") {

				player.GetComponent<Rigidbody> ().AddForce (Vector3.left * knockback, ForceMode.Impulse);
				GameObject DebrisClone = Instantiate (debris, playerSpawn.position, Quaternion.identity);
				DebrisClone.SetActive (true);

			}
		}
	}
}
