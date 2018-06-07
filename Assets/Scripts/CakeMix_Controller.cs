using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeMix_Controller : MonoBehaviour {

	public GameObject opponent, cam;
	public float cakemixPower, knockback;

	// Use this for initialization
	void Start () {

		cakemixPower = 0.01f;
		knockback = 5f;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnParticleCollision(GameObject other){

		if (other.gameObject.name == "Opponent") {

			opponent.GetComponent<MainOpponent_Controller> ().newHealth -= cakemixPower;
			cam.GetComponent<Camera_Controller> ().ZoomPunch ();

			if (gameObject.name == "CakeMixR(Clone)") {

				opponent.GetComponent<Rigidbody> ().AddForce (Vector3.right * knockback, ForceMode.Impulse);

			}
			if (gameObject.name == "CakeMixL(Clone)") {

				opponent.GetComponent<Rigidbody> ().AddForce (Vector3.left * knockback, ForceMode.Impulse);

			}

		}

	}
}
