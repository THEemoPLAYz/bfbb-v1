using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End_Level : MonoBehaviour {

	public GameObject player, opponent, endMessage, healthPlayer, healthOpponent, timer;
	public Camera cam;
	public AnimationClip healthExit;
	public AudioSource audio;
	public AudioClip winMusic, loseMusic;
	public float lerpSpeed;

	public Vector3 playerPosition;


	void Start(){

		cam.GetComponent<Camera_Controller> ().enabled = false;

	}
	void Update(){

		playerPosition = new Vector3 (player.transform.position.x + 2f, player.transform.position.y, player.transform.position.z - 7f);
		cam.transform.position = Vector3.Lerp (cam.transform.position, playerPosition, Time.deltaTime * lerpSpeed);
		cam.fieldOfView = 36f;

	}

	public void Win(){

		player.GetComponent<Animator> ().SetTrigger ("Win");
		audio.PlayOneShot (winMusic);
		opponent.GetComponent<End_Level>().enabled = true;
		Animation playerAnim = healthPlayer.GetComponent<Animation> ();
		Animation opponentAnim = healthOpponent.GetComponent<Animation> ();
		Animation timerAnim = timer.GetComponent<Animation> ();
		playerAnim.clip = healthExit;
		opponentAnim.clip = healthExit;
		timerAnim.clip = healthExit;
		timerAnim.Play ();
		playerAnim.Play ();
		opponentAnim.Play ();
		endMessage.SetActive (true);

	}

	public void Lose(){

		opponent.GetComponent<End_Level>().enabled = true;
		Animation playerAnim = healthPlayer.GetComponent<Animation> ();
		Animation opponentAnim = healthOpponent.GetComponent<Animation> ();
		playerAnim.clip = healthExit;
		opponentAnim.clip = healthExit;
		playerAnim.Play ();
		opponentAnim.Play ();
		endMessage.SetActive (true);

	}
}
