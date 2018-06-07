using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpongySplash_Controller : MonoBehaviour {

	public GameObject player, opponent, cam;
	public float cakemixPower, knockback;
	public AudioSource audio;
	public List<AudioClip> punchList;
	private ParticleSystem ps;
	private ParticleCollisionEvent[] collisionEvents;
	private Vector3 collisionHitLoc;

	// Use this for initialization
	void Start () {

		float direction = opponent.transform.position.x - player.transform.position.x;

		if (direction < 0f) {

			opponent.GetComponent<Rigidbody> ().AddForce (Vector3.left * knockback, ForceMode.Impulse);

		} else if (direction > 0f) {

			opponent.GetComponent<Rigidbody> ().AddForce (Vector3.right * knockback, ForceMode.Impulse);

		}

		ps = gameObject.GetComponent<ParticleSystem> ();
		collisionEvents = new ParticleCollisionEvent[16];

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnParticleCollision(GameObject other) {

		if (other.gameObject.tag == "Opponent") {
			opponent.GetComponent<MainOpponent_Controller> ().newHealth -= cakemixPower;
			cam.GetComponent<Camera_Controller> ().ZoomPunch ();

			int randomize = Random.Range (0, punchList.Count);
			AudioClip punch = punchList [randomize];
			audio.PlayOneShot (punch);

		}
	}
	}

