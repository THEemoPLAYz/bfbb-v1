using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pencil_ControllerPlayer : MonoBehaviour {

	public Rigidbody rb;
	public GameObject punchtriggerR, punchTriggerL, cam, specialParticles, playerCenter, opponent;

	[Header("Initialize Stuff")]
	public BoxCollider collider;
	public Vector3 ColliderPosition;
	public Vector3 ColliderScale;

	[Space]

	[Header("Variables")]
	public float speed, jumppower;
	public bool jumped;

	[Space]

	[Header("Animation")]
	public Animator anim;
	public RuntimeAnimatorController pencilcontroller;

	[Space]

	[Header("Sprite")]
	public Sprite punchR;
	public Sprite punchL;
	public SpriteRenderer playersprite;

	// Use this for initialization
	void Start () {
		anim.runtimeAnimatorController = pencilcontroller;
		collider.center = new Vector3 (ColliderPosition.x, ColliderPosition.y, ColliderPosition.z);
		collider.size = new Vector3 (ColliderScale.x, ColliderScale.y, ColliderScale.z);
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {

			rb.velocity = new Vector3 (0f, rb.velocity.y, rb.velocity.z);
			transform.Translate (Vector3.left * speed * Time.deltaTime);
			anim.SetInteger ("Direction", -1);
			anim.SetBool ("IsMoving", true);

		} else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {

			rb.velocity = new Vector3 (0f, rb.velocity.y, rb.velocity.z);
			transform.Translate (Vector3.right * speed * Time.deltaTime);
			anim.SetInteger ("Direction", 1);
			anim.SetBool ("IsMoving", true);

		} else if (Input.GetKeyDown (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {

			if (jumped == false) {
				anim.SetBool ("Jumped", true);
			}
		} else if (Input.GetKeyDown (KeyCode.Z)) {

			anim.SetTrigger ("Punch");

		} else if (Input.GetKey (KeyCode.Z) && Input.GetKey (KeyCode.X)) {

			if (gameObject.GetComponent<Player_Controller> ().powerbar.value == 1f) {

				anim.SetTrigger ("Special");

			}

		}

		else {

			anim.SetBool ("IsMoving", false);

		}

		if (playersprite.sprite == punchR) {

			punchtriggerR.SetActive (true);
			punchTriggerL.SetActive (false);

		} else if (playersprite.sprite == punchL) {

			punchTriggerL.SetActive (true);
			punchtriggerR.SetActive (false);

		} else {

			punchtriggerR.SetActive (false);
			punchTriggerL.SetActive (false);

		}

		if (transform.position.x > 21f) {

			transform.position = new Vector3 (21f, transform.position.y, transform.position.z);

		} else if (transform.position.x < -21f) {

			transform.position = new Vector3 (-21f, transform.position.y, transform.position.z);

		}

	}

	void OnCollisionEnter (Collision c){

		jumped = false;
		anim.SetBool ("Jumped", false);

	}

	public void Jump(){

		if (jumped == false) {
			rb.AddForce (Vector3.up * jumppower, ForceMode.Impulse);
			jumped = true;
		}
	}


	//Special Handlers
	public void Special_CameraFocusToPlayer(){

		cam.GetComponent<Camera_Controller> ().enabled = false;
		cam.GetComponent<Special_PlayerFocus> ().enabled = true;
		opponent.GetComponent<David_ControllerAI> ().enabled = false;

	}
	public void Special_CameraBackToNormal(){

		cam.GetComponent<Camera_Controller> ().enabled = true;
		cam.GetComponent<Special_PlayerFocus> ().enabled = false;
		opponent.GetComponent<David_ControllerAI> ().enabled = true;

	}
	public void Special_Particles(){

		GameObject specialClone = Instantiate (specialParticles, playerCenter.transform.position, Quaternion.identity);
		specialClone.SetActive (true);

	}
}
