using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HadokenR_Controller : MonoBehaviour {

	public float speed, hadokenPower, knockback, powerValue;
	public GameObject player, opponent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.right * speed * Time.deltaTime);

	}
	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Opponent")) {

			opponent.GetComponent<MainOpponent_Controller> ().newHealth -= hadokenPower;
			Destroy (gameObject);

		}

	}

}
