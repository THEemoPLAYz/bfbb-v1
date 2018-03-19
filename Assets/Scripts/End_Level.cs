using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End_Level : MonoBehaviour {

	public GameObject player, opponent, endMessageWin, endMessageLose, healthPlayer, healthOpponent, timer, playerCenter;
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

		playerPosition = new Vector3 (playerCenter.transform.position.x + 2f, playerCenter.transform.position.y, playerCenter.transform.position.z - 7f);
		cam.transform.position = Vector3.Lerp (cam.transform.position, playerPosition, Time.deltaTime * lerpSpeed);
		cam.fieldOfView = 36f;

	}

	public void Win(){

		player.GetComponent<Player_Controller> ().enabled = false;
		player.GetComponent<Pencil_ControllerPlayer> ().enabled = false;
		player.GetComponent<Woody_ControllerPlayer> ().enabled = false;

		opponent.GetComponent<David_ControllerAI> ().enabled = false;

		player.GetComponent<Animator> ().SetTrigger ("Win");
		audio.PlayOneShot (winMusic);
		opponent.GetComponent<End_Level>().enabled = true;
		opponent.GetComponent<BoxCollider> ().isTrigger = true;
		Animation playerAnim = healthPlayer.GetComponent<Animation> ();
		Animation opponentAnim = healthOpponent.GetComponent<Animation> ();
		Animation timerAnim = timer.GetComponent<Animation> ();
		playerAnim.clip = healthExit;
		opponentAnim.clip = healthExit;
		timerAnim.clip = healthExit;
		timerAnim.Play ();
		playerAnim.Play ();
		opponentAnim.Play ();
		endMessageWin.SetActive (true);

	}

	public void Lose(){

		player.GetComponent<Player_Controller> ().enabled = false;
		player.GetComponent<Pencil_ControllerPlayer> ().enabled = false;
		player.GetComponent<Woody_ControllerPlayer> ().enabled = false;

		opponent.GetComponent<David_ControllerAI> ().enabled = false;

		opponent.GetComponent<Animator> ().SetTrigger ("Win");
		audio.PlayOneShot (loseMusic);
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
		endMessageLose.SetActive (true);

	}
}
