using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class SpecialAttack_Pen : MonoBehaviour {

	public float punchpower;
    public float knockback;
	public Transform opponentSpawn;
	public AudioSource audio;
	public List<AudioClip> punchList;
	public GameObject opponent, player, cam;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){

        CameraShaker.Instance.ShakeOnce(3f, 5f, 0.1f, 0.5f);

		if (other.gameObject.CompareTag ("Opponent")) {
			opponent.GetComponent<MainOpponent_Controller> ().newHealth -= (punchpower / 100f);
			int randomize = Random.Range (0, punchList.Count);
			AudioClip punch = punchList [randomize];
			audio.PlayOneShot(punch);
			cam.GetComponent<Camera_Controller> ().ZoomPunch ();

			if (gameObject.name == "SpecialTriggerR") {

				opponent.GetComponent<Rigidbody> ().AddForce (Vector3.right * knockback, ForceMode.Impulse);
                opponent.GetComponent<MainOpponent_Controller>().SpawnOpponentDebris();

			} else if (gameObject.name == "SpecialTriggerL") {

                opponent.GetComponent<Rigidbody> ().AddForce (Vector3.left * knockback, ForceMode.Impulse);
                opponent.GetComponent<MainOpponent_Controller>().SpawnOpponentDebris();

            }
		}
	}
}
