using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special_AttackPencil : MonoBehaviour {

	public float power, knockback;
	public GameObject opponent, cam, specialParticle;
	public Animator opponentAnim;
	public AudioSource audio;
	public AudioClip superslap;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Opponent")) {

			opponent.GetComponent<MainOpponent_Controller> ().newHealth -= power;
			//opponentAnim.SetTrigger ("Stun");
			audio.PlayOneShot (superslap);
			cam.GetComponent<Camera_Controller> ().ZoomSpecial();
			gameObject.SetActive (false);

		}
		if (gameObject.name == "SpecialTriggerR") {

			opponent.GetComponent<Rigidbody> ().AddForce (Vector3.right * knockback, ForceMode.Impulse);
			GameObject specialParticles = Instantiate (specialParticle, transform.position, Quaternion.identity);
			specialParticle.SetActive (true);

		}
		if (gameObject.name == "SpecialTriggerL") {

			opponent.GetComponent<Rigidbody> ().AddForce (Vector3.left * knockback, ForceMode.Impulse);
			GameObject specialParticles = Instantiate (specialParticle, transform.position, Quaternion.identity);
			specialParticle.SetActive (true);

		}
			
	}
}
