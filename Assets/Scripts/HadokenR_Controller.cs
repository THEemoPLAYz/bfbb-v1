using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

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

            CameraShaker.Instance.ShakeOnce(2f, 5f, 0.1f, 0.5f);
            opponent.GetComponent<MainOpponent_Controller> ().newHealth -= hadokenPower;
            opponent.GetComponent<Rigidbody>().AddForce(Vector3.right * knockback, ForceMode.Impulse);

            Destroy (gameObject);

		}

	}

}
